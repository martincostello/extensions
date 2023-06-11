// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using Microsoft.Shared.Diagnostics;

namespace Microsoft.Extensions.Telemetry.Testing.Metering;

/// <summary>
/// Represents a single measurement performed by an instrument.
/// </summary>
/// <typeparam name="T">The type of metric measurement value.</typeparam>
[Experimental]
public sealed class CollectedMeasurement<T>
    where T : struct
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CollectedMeasurement{T}"/> class.
    /// </summary>
    /// <param name="value">The measurement's value.</param>
    /// <param name="tags">The dimensions of this measurement.</param>
    /// <param name="timestamp">The time that the measurement occurred at.</param>
    internal CollectedMeasurement(T value, ReadOnlySpan<KeyValuePair<string, object?>> tags, DateTimeOffset timestamp)
    {
        var d = new Dictionary<string, object?>();
        foreach (var tag in tags)
        {
            d[tag.Key] = tag.Value;
        }

        Tags = d;
        Timestamp = timestamp;
        Value = value;
    }

    /// <summary>
    /// Gets a measurement's value.
    /// </summary>
    public T Value { get; }

    /// <summary>
    /// Gets a timestamp indicating when the measurement was recorded.
    /// </summary>
    public DateTimeOffset Timestamp { get; }

    /// <summary>
    /// Gets the measurement's dimensions.
    /// </summary>
    public IReadOnlyDictionary<string, object?> Tags { get; }

    /// <summary>
    /// Gets a string representing the measurement.
    /// </summary>
    /// <returns>The string representation of this measurement.</returns>
    public override string ToString() => $"[{Timestamp.ToString("HH:mm:ss.ffff", CultureInfo.InvariantCulture)}] {Value}";

    /// <summary>
    /// Checks that the measurement includes a specific set of dimensions with specific values.
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
}
