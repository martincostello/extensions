// Assembly 'Microsoft.Extensions.Telemetry.Testing'

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

namespace Microsoft.Extensions.Telemetry.Testing.Logging;

/// <summary>
/// Options for the fake logger.
/// </summary>
public class FakeLogCollectorOptions
{
    /// <summary>
    /// Gets or sets the logger categories for whom records are collected.
    /// </summary>
    /// <remarks>
    /// Defaults to an empty set, which doesn't filter any records.
    /// If not empty, only records coming from loggers in these categories will be collected by the fake logger.
    /// </remarks>
    public ISet<string> FilteredCategories { get; set; }

    /// <summary>
    /// Gets or sets the logging levels for whom records are collected.
    /// </summary>
    /// <remarks>
    /// Defaults to an empty set, which doesn't filter any records.
    /// If not empty, only records with the given level will be collected by the fake logger.
    /// </remarks>
    public ISet<LogLevel> FilteredLevels { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to collect records that are logged when the associated log level is currently disabled.
    /// </summary>
    /// <remarks>
    /// Defaults to <see langword="true" />.
    /// </remarks>
    public bool CollectRecordsForDisabledLogLevels { get; set; }

    /// <summary>
    /// Gets or sets the time provider to use when time-stamping log records.
    /// </summary>
    /// <remarks>
    /// Defaults to <see cref="P:System.TimeProvider.System" />.
    /// </remarks>
    public TimeProvider TimeProvider { get; set; }

    /// <summary>
    /// Gets or sets an output sink where every record harvested by the collector is sent.
    /// </summary>
    /// <remarks>
    /// By setting this property, you can have all log records harvested by the collector be copied somewhere convenient.
    /// Defaults to <see langword="null" />.
    /// </remarks>
    public Action<string>? OutputSink { get; set; }

    /// <summary>
    /// Gets or sets a delegate that is used to format log records in a specialized way before sending them to the registered output sink.
    /// </summary>
    public Func<FakeLogRecord, string> OutputFormatter { get; set; }

    public FakeLogCollectorOptions();
}
