// Assembly 'Microsoft.Extensions.Telemetry.Testing'

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Telemetry.Testing.Metering.Internal;

namespace Microsoft.Extensions.Telemetry.Testing.Metering;

/// <summary>
/// The metric measurements holder that contains information belonging to one named metric.
/// </summary>
/// <typeparam name="T">The type of metric measurement value.</typeparam>
[System.Diagnostics.CodeAnalysis.Experimental]
public sealed class MetricValuesHolder<T> where T : struct
{
    /// <summary>
    /// Gets the metric name.
    /// </summary>
    public string MetricName { get; }

    /// <summary>
    /// Gets all metric values recorded by the instrument.
    /// </summary>
    public IReadOnlyCollection<MetricValue<T>> AllValues { get; }

    /// <summary>
    /// Gets the latest recorded metric measurement value.
    /// </summary>
    public T? LatestWrittenValue { get; }

    /// <summary>
    /// Gets the <see cref="T:Microsoft.Extensions.Telemetry.Testing.Metering.MetricValue`1" /> object containing whole information about the latest recorded metric measurement.
    /// </summary>
    public MetricValue<T>? LatestWritten { get; }

    /// <summary>
    /// Gets a recorded metric measurement value by given dimensions.
    /// </summary>
    /// <param name="tags">The dimensions of a metric measurement.</param>
    /// <returns>The metric measurement value or <see langword="null" /> if it does not exist.</returns>
    public T? GetValue(params KeyValuePair<string, object?>[] tags);

    /// <summary>
    /// Clears all metric measurements information.
    /// </summary>
    public void Clear();
}
