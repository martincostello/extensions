// Assembly 'Microsoft.Extensions.Telemetry.Console'

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Microsoft.Extensions.Telemetry.Console;

public static class LoggingConsoleExtensions
{
    public static ILoggingBuilder AddConsoleExporter(this ILoggingBuilder builder);
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static ILoggingBuilder AddConsoleExporter(this ILoggingBuilder builder, Action<LoggingConsoleOptions> configure);
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static ILoggingBuilder AddConsoleExporter(this ILoggingBuilder builder, IConfigurationSection section);
}
