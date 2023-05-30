// Assembly 'Microsoft.Extensions.Telemetry.Console'

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Telemetry.Console;

[System.Diagnostics.CodeAnalysis.Experimental]
public class LoggingConsoleOptions
{
    public bool IncludeScopes { get; set; }
    public string? TimestampFormat { get; set; }
    public bool UseUtcTimestamp { get; set; }
    public bool IncludeTimestamp { get; set; }
    public bool IncludeLogLevel { get; set; }
    public bool IncludeCategory { get; set; }
    public bool IncludeExceptionStacktrace { get; set; }
    public bool IncludeTraceId { get; set; }
    public bool IncludeSpanId { get; set; }
    public bool ColorsEnabled { get; set; }
    public ConsoleColor DimmedColor { get; set; }
    public ConsoleColor? DimmedBackgroundColor { get; set; }
    public ConsoleColor ExceptionColor { get; set; }
    public ConsoleColor? ExceptionBackgroundColor { get; set; }
    public ConsoleColor ExceptionStackTraceColor { get; set; }
    public ConsoleColor? ExceptionStackTraceBackgroundColor { get; set; }
    public LoggingConsoleOptions();
}
