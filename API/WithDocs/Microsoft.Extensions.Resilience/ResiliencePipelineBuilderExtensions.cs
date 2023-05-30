// Assembly 'Microsoft.Extensions.Resilience'

using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Resilience.Options;

namespace Microsoft.Extensions.Resilience;

/// <summary>
/// Extension methods for pipeline builders.
/// </summary>
public static class ResiliencePipelineBuilderExtensions
{
    /// <summary>
    /// Adds a bulkhead policy with default options to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <returns>Current instance.</returns>
    public static IResiliencePipelineBuilder<TResult> AddBulkheadPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName);

    /// <summary>
    /// Adds a bulkhead policy to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="configure">The action that configures the default policy options.</param>
    /// <returns>Current instance.</returns>
    public static IResiliencePipelineBuilder<TResult> AddBulkheadPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, Action<BulkheadPolicyOptions> configure);

    /// <summary>
    /// Adds a bulkhead policy to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="section">The configuration that the options will bind against.</param>
    /// <returns>Current instance.</returns>
    public static IResiliencePipelineBuilder<TResult> AddBulkheadPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, IConfigurationSection section);

    /// <summary>
    /// Adds a bulkhead policy to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="section">The configuration that the options will bind against.</param>
    /// <param name="configure">The action that configures the policy options after <paramref name="section" /> is applied.</param>
    /// <returns>Current instance.</returns>
    /// <remarks>
    /// Keep in mind that the <paramref name="configure" /> delegate will override anything that was configured using <paramref name="section" />.
    /// </remarks>
    public static IResiliencePipelineBuilder<TResult> AddBulkheadPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, IConfigurationSection section, Action<BulkheadPolicyOptions> configure);

    /// <summary>
    /// Adds a circuit breaker policy with default options to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <returns>Current instance.</returns>
    public static IResiliencePipelineBuilder<TResult> AddCircuitBreakerPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName);

    /// <summary>
    /// Adds a circuit breaker policy to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="configure">The action that configures the default policy options.</param>
    /// <returns>Current instance.</returns>
    public static IResiliencePipelineBuilder<TResult> AddCircuitBreakerPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, Action<CircuitBreakerPolicyOptions<TResult>> configure);

    /// <summary>
    /// Adds a circuit breaker policy to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="section">The configuration that the options will bind against.</param>
    /// <returns>Current instance.</returns>
    public static IResiliencePipelineBuilder<TResult> AddCircuitBreakerPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, IConfigurationSection section);

    /// <summary>
    /// Adds a circuit breaker policy to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="section">The configuration that the options will bind against.</param>
    /// <param name="configure">The action that configures the policy options after <paramref name="section" /> is applied.</param>
    /// <returns>Current instance.</returns>
    /// <remarks>
    /// Keep in mind that the <paramref name="configure" /> delegate will override anything that was configured using <paramref name="section" />.
    /// </remarks>
    public static IResiliencePipelineBuilder<TResult> AddCircuitBreakerPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, IConfigurationSection section, Action<CircuitBreakerPolicyOptions<TResult>> configure);

    /// <summary>
    /// Adds a fallback policy with default options to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="provider">The task performed in the fallback scenario when the initial execution encounters a transient failure.</param>
    /// <returns>Current instance.</returns>
    public static IResiliencePipelineBuilder<TResult> AddFallbackPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, FallbackScenarioTaskProvider<TResult> provider);

    /// <summary>
    /// Adds a fallback policy to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="provider">The task performed in the fallback scenario when the initial execution encounters a transient failure.</param>
    /// <param name="configure">The action that configures the default policy options.</param>
    /// <returns>Current instance.</returns>
    public static IResiliencePipelineBuilder<TResult> AddFallbackPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, FallbackScenarioTaskProvider<TResult> provider, Action<FallbackPolicyOptions<TResult>> configure);

    /// <summary>
    /// Adds a fallback policy to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="provider">The task performed in the fallback scenario when the initial execution encounters a transient failure.</param>
    /// <param name="section">The configuration that the options will bind against.</param>
    /// <returns>Current instance.</returns>
    public static IResiliencePipelineBuilder<TResult> AddFallbackPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, FallbackScenarioTaskProvider<TResult> provider, IConfigurationSection section);

    /// <summary>
    /// Adds a fallback policy to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="provider">The task performed in the fallback scenario when the initial execution encounters a transient failure.</param>
    /// <param name="section">The configuration that the options will bind against.</param>
    /// <param name="configure">The action that configures the policy options after <paramref name="section" /> is applied.</param>
    /// <returns>Current instance.</returns>
    /// <remarks>
    /// Keep in mind that the <paramref name="configure" /> delegate will override anything that was configured using <paramref name="section" />.
    /// </remarks>
    public static IResiliencePipelineBuilder<TResult> AddFallbackPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, FallbackScenarioTaskProvider<TResult> provider, IConfigurationSection section, Action<FallbackPolicyOptions<TResult>> configure);

    /// <summary>
    /// Adds a hedging policy with default options to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="provider">The hedged task provider.</param>
    /// <returns>Current instance.</returns>
    public static IResiliencePipelineBuilder<TResult> AddHedgingPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, HedgedTaskProvider<TResult> provider);

    /// <summary>
    /// Adds a hedging policy to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="provider">The hedged task provider.</param>
    /// <param name="configure">The action that configures the default policy options.</param>
    /// <returns>Current instance.</returns>
    public static IResiliencePipelineBuilder<TResult> AddHedgingPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, HedgedTaskProvider<TResult> provider, Action<HedgingPolicyOptions<TResult>> configure);

    /// <summary>
    /// Adds a hedging policy to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="provider">The hedged task provider.</param>
    /// <param name="section">The configuration that the options will bind against.</param>
    /// <returns>Current instance.</returns>
    public static IResiliencePipelineBuilder<TResult> AddHedgingPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, HedgedTaskProvider<TResult> provider, IConfigurationSection section);

    /// <summary>
    /// Adds a hedging policy to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="provider">The hedged task provider.</param>
    /// <param name="section">The configuration that the options will bind against.</param>
    /// <param name="configure">The action that configures the policy options after <paramref name="section" /> is applied.</param>
    /// <returns>Current instance.</returns>
    /// <remarks>
    /// Keep in mind that the <paramref name="configure" /> delegate will override anything that was configured using <paramref name="section" />.
    /// </remarks>
    public static IResiliencePipelineBuilder<TResult> AddHedgingPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, HedgedTaskProvider<TResult> provider, IConfigurationSection section, Action<HedgingPolicyOptions<TResult>> configure);

    /// <summary>
    /// Adds a retry policy with default options to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <returns>Current instance.</returns>
    public static IResiliencePipelineBuilder<TResult> AddRetryPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName);

    /// <summary>
    /// Adds a retry policy to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="configure">The action that configures the default policy options.</param>
    /// <returns>Current instance.</returns>
    public static IResiliencePipelineBuilder<TResult> AddRetryPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, Action<RetryPolicyOptions<TResult>> configure);

    /// <summary>
    /// Adds a retry policy to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="section">The configuration that the options will bind against.</param>
    /// <returns>Current instance.</returns>
    public static IResiliencePipelineBuilder<TResult> AddRetryPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, IConfigurationSection section);

    /// <summary>
    /// Adds a retry policy to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="section">The configuration that the options will bind against.</param>
    /// <param name="configure">The action that configures the policy options after <paramref name="section" /> is applied.</param>
    /// <returns>Current instance.</returns>
    /// <remarks>
    /// Keep in mind that the <paramref name="configure" /> delegate will override anything that was configured using <paramref name="section" />.
    /// </remarks>
    public static IResiliencePipelineBuilder<TResult> AddRetryPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, IConfigurationSection section, Action<RetryPolicyOptions<TResult>> configure);

    /// <summary>
    /// Adds a timeout policy with default options to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <returns>Current instance.</returns>
    public static IResiliencePipelineBuilder<TResult> AddTimeoutPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName);

    /// <summary>
    /// Adds a timeout policy to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="configure">The action that configures the default policy options.</param>
    /// <returns>Current instance.</returns>
    public static IResiliencePipelineBuilder<TResult> AddTimeoutPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, Action<TimeoutPolicyOptions> configure);

    /// <summary>
    /// Adds a timeout policy to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="section">The configuration that the options will bind against.</param>
    /// <returns>Current instance.</returns>
    public static IResiliencePipelineBuilder<TResult> AddTimeoutPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, IConfigurationSection section);

    /// <summary>
    /// Adds a timeout policy to a pipeline.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="builder">The policy pipeline builder.</param>
    /// <param name="policyName">The policy name.</param>
    /// <param name="section">The configuration that the options will bind against.</param>
    /// <param name="configure">The action that configures the policy options after <paramref name="section" /> is applied.</param>
    /// <returns>Current instance.</returns>
    /// <remarks>
    /// Keep in mind that the <paramref name="configure" /> delegate will override anything that was configured using <paramref name="section" />.
    /// </remarks>
    public static IResiliencePipelineBuilder<TResult> AddTimeoutPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, IConfigurationSection section, Action<TimeoutPolicyOptions> configure);
}
