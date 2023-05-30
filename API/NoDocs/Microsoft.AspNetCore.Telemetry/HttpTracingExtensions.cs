// Assembly 'Microsoft.AspNetCore.Telemetry'

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenTelemetry.Trace;

namespace Microsoft.AspNetCore.Telemetry;

public static class HttpTracingExtensions
{
    public static TracerProviderBuilder AddHttpTracing(this TracerProviderBuilder builder);
    public static TracerProviderBuilder AddHttpTracing(this TracerProviderBuilder builder, Action<HttpTracingOptions> configure);
    public static TracerProviderBuilder AddHttpTracing(this TracerProviderBuilder builder, IConfigurationSection section);
    public static TracerProviderBuilder AddHttpTraceEnricher<T>(this TracerProviderBuilder builder) where T : class, IHttpTraceEnricher;
    public static TracerProviderBuilder AddHttpTraceEnricher(this TracerProviderBuilder builder, IHttpTraceEnricher enricher);
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static IServiceCollection AddHttpTraceEnricher<T>(this IServiceCollection services) where T : class, IHttpTraceEnricher;
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static IServiceCollection AddHttpTraceEnricher(this IServiceCollection services, IHttpTraceEnricher enricher);
}
