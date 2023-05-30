// Assembly 'Microsoft.Extensions.Diagnostics.HealthChecks.Core'

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.Diagnostics.HealthChecks;

public static class CoreHealthChecksExtensions
{
    public static IHealthChecksBuilder AddApplicationLifecycleHealthCheck(this IHealthChecksBuilder builder);
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static IHealthChecksBuilder AddApplicationLifecycleHealthCheck(this IHealthChecksBuilder builder, params string[] tags);
    public static IHealthChecksBuilder AddApplicationLifecycleHealthCheck(this IHealthChecksBuilder builder, IEnumerable<string> tags);
    public static IServiceCollection AddKubernetesHealthCheckPublisher(this IServiceCollection services);
    public static IServiceCollection AddKubernetesHealthCheckPublisher(this IServiceCollection services, IConfigurationSection section);
    public static IServiceCollection AddKubernetesHealthCheckPublisher(this IServiceCollection services, Action<KubernetesHealthCheckPublisherOptions> configure);
    public static IHealthChecksBuilder AddManualHealthCheck(this IHealthChecksBuilder builder);
    public static IHealthChecksBuilder AddManualHealthCheck(this IHealthChecksBuilder builder, params string[] tags);
    public static IHealthChecksBuilder AddManualHealthCheck(this IHealthChecksBuilder builder, IEnumerable<string> tags);
    public static void ReportHealthy(this IManualHealthCheck manualHealthCheck);
    public static void ReportUnhealthy(this IManualHealthCheck manualHealthCheck, string reason);
    public static IServiceCollection AddTelemetryHealthCheckPublisher(this IServiceCollection services);
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static IServiceCollection AddTelemetryHealthCheckPublisher(this IServiceCollection services, IConfigurationSection section);
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static IServiceCollection AddTelemetryHealthCheckPublisher(this IServiceCollection services, Action<TelemetryHealthCheckPublisherOptions> configure);
}
