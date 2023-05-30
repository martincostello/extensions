// Assembly 'Microsoft.Extensions.Telemetry.Console'

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Microsoft.Extensions.Telemetry.Console;

/// <summary>
/// Console exporter logging extensions for R9 logger.
/// </summary>
public static class LoggingConsoleExtensions
{
    /// <summary>
    /// Adds console exporter as a configuration to the OpenTelemetry ILoggingBuilder.
    /// </summary>
    /// <param name="builder">Logging builder where the exporter will be added.</param>
    /// <returns>The instance of <see cref="T:Microsoft.Extensions.Logging.ILoggingBuilder" /> to chain the calls.</returns>
    public static ILoggingBuilder AddConsoleExporter(this ILoggingBuilder builder);

    /// <summary>
    /// Adds console exporter as a configuration to the OpenTelemetry ILoggingBuilder.
    /// </summary>
    /// <param name="builder">Logging builder where the exporter will be added.</param>
    /// <param name="configure">An action to configure the <see cref="T:Microsoft.Extensions.Telemetry.Console.LoggingConsoleOptions" /> for console output customization.</param>
    /// <returns>The instance of <see cref="T:Microsoft.Extensions.Logging.ILoggingBuilder" /> to chain the calls.</returns>
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static ILoggingBuilder AddConsoleExporter(this ILoggingBuilder builder, Action<LoggingConsoleOptions> configure);

    /// <summary>
    /// Adds console exporter as a configuration to the OpenTelemetry ILoggingBuilder.
    /// </summary>
    /// <param name="builder">Logging builder where the exporter will be added.</param>
    /// <param name="section">The configuration section to bind <see cref="T:Microsoft.Extensions.Telemetry.Console.LoggingConsoleOptions" /> for customization of the console output.</param>
    /// <returns>The instance of <see cref="T:Microsoft.Extensions.Logging.ILoggingBuilder" /> to chain the calls.</returns>
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static ILoggingBuilder AddConsoleExporter(this ILoggingBuilder builder, IConfigurationSection section);
}
