// Assembly 'Microsoft.Extensions.Telemetry.Console'

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.Telemetry.Console;

public static class LatencyConsoleExtensions
{
    public static IServiceCollection AddConsoleLatencyDataExporter(this IServiceCollection services);
    public static IServiceCollection AddConsoleLatencyDataExporter(this IServiceCollection services, Action<LarencyConsoleOptions> configure);
    public static IServiceCollection AddConsoleLatencyDataExporter(this IServiceCollection services, IConfigurationSection section);
}
