// Assembly 'Microsoft.Extensions.Telemetry.Console'

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Telemetry.Console;

/// <summary>
/// Options to configure console logging formatter.
/// </summary>
[System.Diagnostics.CodeAnalysis.Experimental]
public class LoggingConsoleOptions
{
    /// <summary>
    /// Gets or sets a value indicating whether to display scopes.
    /// </summary>
    /// <remarks>
    /// Defaults to <see langword="true" />.
    /// </remarks>
    public bool IncludeScopes { get; set; }

    /// <summary>
    /// Gets or sets format string used to format timestamp in logging messages.
    /// </summary>
    /// <remarks>
    /// Defaults to <c>yyyy-MM-dd HH:mm:ss.fff</c>.
    /// </remarks>
    public string? TimestampFormat { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether or not UTC timezone should be used for timestamps in logging messages.
    /// </summary>
    /// <remarks>
    /// Defaults to <see langword="false" />.
    /// </remarks>
    public bool UseUtcTimestamp { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to display timestamp.
    /// </summary>
    /// <remarks>
    /// Defaults to <see langword="true" />.
    /// </remarks>
    public bool IncludeTimestamp { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to display log level.
    /// </summary>
    /// <remarks>
    /// Defaults to <see langword="true" />.
    /// </remarks>
    public bool IncludeLogLevel { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to display category.
    /// </summary>
    /// <remarks>
    /// Defaults to <see langword="true" />.
    /// </remarks>
    public bool IncludeCategory { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to display stack trace.
    /// </summary>
    /// <remarks>
    /// Defaults to <see langword="true" />.
    /// </remarks>
    public bool IncludeExceptionStacktrace { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to display activity TraceId.
    /// </summary>
    /// <remarks>
    /// Default set to <see langword="true" />.
    /// </remarks>
    public bool IncludeTraceId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to display activity SpanId.
    /// </summary>
    /// <remarks>
    /// Default set to <see langword="true" />.
    /// </remarks>
    public bool IncludeSpanId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether colors are enabled or not.
    /// </summary>
    /// <remarks>Defaults to <see langword="true" />.</remarks>
    public bool ColorsEnabled { get; set; }

    /// <summary>
    /// Gets or sets a value indicating what color to use for dimmed text.
    /// </summary>
    /// <remarks>Defaults to <see cref="F:System.ConsoleColor.DarkGray" />.</remarks>
    public ConsoleColor DimmedColor { get; set; }

    /// <summary>
    /// Gets or sets a value indicating what color to use for dimmed text background.
    /// </summary>
    public ConsoleColor? DimmedBackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets a value indicating what color to use for exception text.
    /// </summary>
    /// <remarks>Defaults to <see cref="F:System.ConsoleColor.Red" />.</remarks>
    public ConsoleColor ExceptionColor { get; set; }

    /// <summary>
    /// Gets or sets a value indicating what color to use for exception text background.
    /// </summary>
    public ConsoleColor? ExceptionBackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets a value indicating what color to use for exception stack trace text.
    /// </summary>
    /// <remarks>Defaults to <see cref="F:System.ConsoleColor.DarkRed" />.</remarks>
    public ConsoleColor ExceptionStackTraceColor { get; set; }

    /// <summary>
    /// Gets or sets a value indicating what color to use for exception stack trace text background.
    /// </summary>
    public ConsoleColor? ExceptionStackTraceBackgroundColor { get; set; }

    public LoggingConsoleOptions();
}
