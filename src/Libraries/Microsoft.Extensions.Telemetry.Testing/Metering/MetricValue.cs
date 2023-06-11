// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Shared.Diagnostics;

namespace Microsoft.Extensions.Telemetry.Testing.Metering;

/// <summary>
/// Tracks a single metric's value.
/// </summary>
/// <typeparam name="T">The type of metric measurement value.</typeparam>
[Experimental]
public sealed class MetricValue<T>
    where T : struct
{

    /// <summary>
    /// Initializes a new instance of the <see cref="MetricValue{T}"/> class.
    /// </summary>
    /// <param name="measurement">The initial measurement made by the instrument.</param>
    /// <param name="tags">The dimensions describing the specific value.</param>
    internal MetricValue(T measurement, ReadOnlySpan<KeyValuePair<string, object?>> tags)
    {
        var d = new Dictionary<string, object?>();
        foreach (var tag in tags)
        {
            d[tag.Key] = tag.Value;
        }

        Tags = d;
        Value = measurement;
    }

    internal MetricValue(T measurement, IReadOnlyDictionary<string, object?> tags, int numWrites)
    {
        Tags = tags;
        Value = measurement;
        NumWrites = numWrites;
    }

    /// <summary>
    /// Gets the current value.
    /// </summary>
    public T Value { get; internal set; }

    /// <summary>
    /// Gets a collection of measurement's dimensions.
    /// </summary>
    public IReadOnlyDictionary<string, object?> Tags { get; }

    /// <summary>
    /// Gets the number of times this metric value has been written to.
    /// </summary>
    public int NumWrites { get; private set; } = 1;

    /// <summary>
    /// Checks that the instrument value includes a specific set of dimensions with specific values.
    /// </summary>
    /// <param name="tags">The set of dimensions to check.</param>
    /// <returns><see langword="true"/> if all the dimensions exist in the measurement with matching values, otherwise <see langword="false"/>.</returns>
    public bool ContainsDimensions(params KeyValuePair<string, object?>[] tags)
    {
        foreach (var kvp in Throw.IfNull(tags))
        {
            var found = false;
            foreach (var kvp2 in Tags)
            {
                if (kvp2.Key == kvp.Key)
                {
                    if (kvp2.Value == null)
                    {
                        if (kvp.Value != null)
                        {
                            return false;
                        }

                        found = true;
                        break;
                    }

                    if (!kvp2.Value.Equals(kvp.Value))
                    {
                        return false;
                    }

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// Gets a string representation of this value.
    /// </summary>
    /// <returns>The value in string form.</returns>
    public override string? ToString() => Value.ToString();

    internal void Add(T value)
    {
        NumWrites++;

        var valueObj = (object)Value;
        var valueToAddObj = (object)value;

        object result = value switch
        {
            byte => (byte)((byte)valueObj + (byte)valueToAddObj),
            short => (short)((short)valueObj + (short)valueToAddObj),
            int => (int)valueObj + (int)valueToAddObj,
            long => (long)valueObj + (long)valueToAddObj,
            float => (float)valueObj + (float)valueToAddObj,
            double => (double)valueObj + (double)valueToAddObj,
            decimal => (decimal)valueObj + (decimal)valueToAddObj,
            _ => throw new InvalidOperationException($"The type {typeof(T).FullName} is not supported as a metering measurement value type."),
        };

        Value = (T)result;
    }

    internal void Update(T value)
    {
        NumWrites++;
        Value = value;
    }
}
