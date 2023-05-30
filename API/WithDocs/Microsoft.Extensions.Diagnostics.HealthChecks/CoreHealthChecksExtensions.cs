// Assembly 'Microsoft.Extensions.Diagnostics.HealthChecks.Core'

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.Diagnostics.HealthChecks;

/// <summary>
/// Controls various health check features.
/// </summary>
public static class CoreHealthChecksExtensions
{
    /// <summary>
    /// Registers a health check provider that's tied to the application's lifecycle.
    /// </summary>
    /// <param name="builder">The builder to add the provider to.</param>
    /// <returns>The value of <paramref name="builder" />.</returns>
    /// <exception cref="T:System.ArgumentNullException">If <paramref name="builder" /> is <see langword="null" />.</exception>
    public static IHealthChecksBuilder AddApplicationLifecycleHealthCheck(this IHealthChecksBuilder builder);

    /// <summary>
    /// Registers a health check provider that's tied to the application's lifecycle.
    /// </summary>
    /// <param name="builder">The builder to add the provider to.</param>
    /// <param name="tags">A list of tags that can be used to filter health checks.</param>
    /// <returns>The value of <paramref name="builder" />.</returns>
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static IHealthChecksBuilder AddApplicationLifecycleHealthCheck(this IHealthChecksBuilder builder, params string[] tags);

    /// <summary>
    /// Registers a health check provider that's tied to the application's lifecycle.
    /// </summary>
    /// <param name="builder">The builder to add the provider to.</param>
    /// <param name="tags">A list of tags that can be used to filter health checks.</param>
    /// <returns>The value of <paramref name="builder" />.</returns>
    /// <exception cref="T:System.ArgumentNullException">If <paramref name="builder" /> or <paramref name="tags" /> are <see langword="null" />.</exception>
    public static IHealthChecksBuilder AddApplicationLifecycleHealthCheck(this IHealthChecksBuilder builder, IEnumerable<string> tags);

    /// <summary>
    /// Registers a health status publisher which opens a TCP port if the application is considered healthy.
    /// </summary>
    /// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add the publisher to.</param>
    /// <returns>The value of <paramref name="services" />.</returns>
    /// <exception cref="T:System.ArgumentNullException">If <paramref name="services" /> is <see langword="null" />.</exception>
    public static IServiceCollection AddKubernetesHealthCheckPublisher(this IServiceCollection services);

    /// <summary>
    /// Registers a health status publisher which opens a TCP port if the application is considered healthy.
    /// </summary>
    /// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add the publisher to.</param>
    /// <param name="section">Configuration for <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.KubernetesHealthCheckPublisherOptions" />.</param>
    /// <returns>The value of <paramref name="services" />.</returns>
    /// <exception cref="T:System.ArgumentNullException">If <paramref name="services" /> or <paramref name="section" /> are <see langword="null" />.</exception>
    public static IServiceCollection AddKubernetesHealthCheckPublisher(this IServiceCollection services, IConfigurationSection section);

    /// <summary>
    /// Registers a health status publisher which opens a TCP port if the application is considered healthy.
    /// </summary>
    /// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add the publisher to.</param>
    /// <param name="configure">Configuration for <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.KubernetesHealthCheckPublisherOptions" />.</param>
    /// <returns>The value of <paramref name="services" />.</returns>
    /// <exception cref="T:System.ArgumentNullException">If <paramref name="services" /> or <paramref name="configure" /> are <see langword="null" />.</exception>
    public static IServiceCollection AddKubernetesHealthCheckPublisher(this IServiceCollection services, Action<KubernetesHealthCheckPublisherOptions> configure);

    /// <summary>
    /// Registers a health check provider that enables manual control of the application's health.
    /// </summary>
    /// <param name="builder">The builder to add the provider to.</param>
    /// <returns>The value of <paramref name="builder" />.</returns>
    /// <exception cref="T:System.ArgumentNullException">If <paramref name="builder" /> is <see langword="null" />.</exception>
    public static IHealthChecksBuilder AddManualHealthCheck(this IHealthChecksBuilder builder);

    /// <summary>
    /// Registers a health check provider that enables manual control of the application's health.
    /// </summary>
    /// <param name="builder">The builder to add the provider to.</param>
    /// <param name="tags">A list of tags that can be used to filter health checks.</param>
    /// <returns>The value of <paramref name="builder" />.</returns>
    /// <exception cref="T:System.ArgumentNullException">If <paramref name="builder" /> or <paramref name="tags" /> are <see langword="null" />.</exception>
    public static IHealthChecksBuilder AddManualHealthCheck(this IHealthChecksBuilder builder, params string[] tags);

    /// <summary>
    /// Registers a health check provider that enables manual control of the application's health.
    /// </summary>
    /// <param name="builder">The builder to add the provider to.</param>
    /// <param name="tags">A list of tags that can be used to filter health checks.</param>
    /// <returns>The value of <paramref name="builder" />.</returns>
    /// <exception cref="T:System.ArgumentNullException">If <paramref name="builder" /> or <paramref name="tags" /> are <see langword="null" />.</exception>
    public static IHealthChecksBuilder AddManualHealthCheck(this IHealthChecksBuilder builder, IEnumerable<string> tags);

    /// <summary>
    /// Sets the manual health check to the healthy state.
    /// </summary>
    /// <param name="manualHealthCheck">The <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IManualHealthCheck" />.</param>
    /// <exception cref="T:System.ArgumentNullException">If <paramref name="manualHealthCheck" /> is <see langword="null" />.</exception>
    public static void ReportHealthy(this IManualHealthCheck manualHealthCheck);

    /// <summary>
    /// Sets the manual health check to return an unhealthy states and an associated reason.
    /// </summary>
    /// <param name="manualHealthCheck">The <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.IManualHealthCheck" />.</param>
    /// <param name="reason">The reason why the health check is unhealthy.</param>
    /// <exception cref="T:System.ArgumentNullException">If <paramref name="manualHealthCheck" /> is <see langword="null" />.</exception>
    public static void ReportUnhealthy(this IManualHealthCheck manualHealthCheck, string reason);

    /// <summary>
    /// Registers a health check publisher which emits telemetry representing the application's health.
    /// </summary>
    /// <param name="services">The dependency injection container to add the publisher to.</param>
    /// <returns>The value of <paramref name="services" />.</returns>
    /// <exception cref="T:System.ArgumentNullException">If <paramref name="services" /> is <see langword="null" />.</exception>
    public static IServiceCollection AddTelemetryHealthCheckPublisher(this IServiceCollection services);

    /// <summary>
    /// Registers a health check publisher which emits telemetry representing the application's health.
    /// </summary>
    /// <param name="services">The dependency injection container to add the publisher to.</param>
    /// <param name="section">Configuration for <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.TelemetryHealthCheckPublisherOptions" />.</param>
    /// <returns>The value of <paramref name="services" />.</returns>
    /// <exception cref="T:System.ArgumentNullException">If <paramref name="services" /> or <paramref name="section" /> are <see langword="null" />.</exception>
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static IServiceCollection AddTelemetryHealthCheckPublisher(this IServiceCollection services, IConfigurationSection section);

    /// <summary>
    /// Registers a health check publisher which emits telemetry representing the application's health.
    /// </summary>
    /// <param name="services">The dependency injection container to add the publisher to.</param>
    /// <param name="configure">Configuration for <see cref="T:Microsoft.Extensions.Diagnostics.HealthChecks.TelemetryHealthCheckPublisherOptions" />.</param>
    /// <returns>The value of <paramref name="services" />.</returns>
    /// <exception cref="T:System.ArgumentNullException">If <paramref name="services" /> or <paramref name="configure" /> are <see langword="null" />.</exception>
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static IServiceCollection AddTelemetryHealthCheckPublisher(this IServiceCollection services, Action<TelemetryHealthCheckPublisherOptions> configure);
}
