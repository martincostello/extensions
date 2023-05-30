// Assembly 'Microsoft.Extensions.Telemetry.Testing'

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Telemetry.Testing.Metering;

/// <summary>
/// Represents the whole information about a single metric measurement.
/// </summary>
/// <typeparam name="T">The type of metric measurement value.</typeparam>
[System.Diagnostics.CodeAnalysis.Experimental]
public sealed class MetricValue<T> where T : struct
{
    /// <summary>
    /// Gets a measurement's value.
    /// </summary>
    public T Value { get; }

    /// <summary>
    /// Gets a timestamp indicating when a measurement was recorded.
    /// </summary>
    public DateTimeOffset Timestamp { get; }

    /// <summary>
    /// Gets a collection of measurement's dimensions.
    /// </summary>
    public IReadOnlyCollection<KeyValuePair<string, object?>> Tags { get; }

    /// <summary>
    /// Gets a dimension value by a dimension name.
    /// </summary>
    /// <param name="dimensionName">The dimension name.</param>
    /// <returns>The dimension value or <see langword="null" /> if the dimension value was not recorded.</returns>
    public object? GetDimension(string dimensionName);
}
