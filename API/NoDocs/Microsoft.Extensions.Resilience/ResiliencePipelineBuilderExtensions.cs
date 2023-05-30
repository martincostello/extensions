// Assembly 'Microsoft.Extensions.Resilience'

using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Resilience.Options;

namespace Microsoft.Extensions.Resilience;

public static class ResiliencePipelineBuilderExtensions
{
    public static IResiliencePipelineBuilder<TResult> AddBulkheadPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName);
    public static IResiliencePipelineBuilder<TResult> AddBulkheadPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, Action<BulkheadPolicyOptions> configure);
    public static IResiliencePipelineBuilder<TResult> AddBulkheadPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, IConfigurationSection section);
    public static IResiliencePipelineBuilder<TResult> AddBulkheadPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, IConfigurationSection section, Action<BulkheadPolicyOptions> configure);
    public static IResiliencePipelineBuilder<TResult> AddCircuitBreakerPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName);
    public static IResiliencePipelineBuilder<TResult> AddCircuitBreakerPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, Action<CircuitBreakerPolicyOptions<TResult>> configure);
    public static IResiliencePipelineBuilder<TResult> AddCircuitBreakerPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, IConfigurationSection section);
    public static IResiliencePipelineBuilder<TResult> AddCircuitBreakerPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, IConfigurationSection section, Action<CircuitBreakerPolicyOptions<TResult>> configure);
    public static IResiliencePipelineBuilder<TResult> AddFallbackPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, FallbackScenarioTaskProvider<TResult> provider);
    public static IResiliencePipelineBuilder<TResult> AddFallbackPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, FallbackScenarioTaskProvider<TResult> provider, Action<FallbackPolicyOptions<TResult>> configure);
    public static IResiliencePipelineBuilder<TResult> AddFallbackPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, FallbackScenarioTaskProvider<TResult> provider, IConfigurationSection section);
    public static IResiliencePipelineBuilder<TResult> AddFallbackPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, FallbackScenarioTaskProvider<TResult> provider, IConfigurationSection section, Action<FallbackPolicyOptions<TResult>> configure);
    public static IResiliencePipelineBuilder<TResult> AddHedgingPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, HedgedTaskProvider<TResult> provider);
    public static IResiliencePipelineBuilder<TResult> AddHedgingPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, HedgedTaskProvider<TResult> provider, Action<HedgingPolicyOptions<TResult>> configure);
    public static IResiliencePipelineBuilder<TResult> AddHedgingPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, HedgedTaskProvider<TResult> provider, IConfigurationSection section);
    public static IResiliencePipelineBuilder<TResult> AddHedgingPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, HedgedTaskProvider<TResult> provider, IConfigurationSection section, Action<HedgingPolicyOptions<TResult>> configure);
    public static IResiliencePipelineBuilder<TResult> AddRetryPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName);
    public static IResiliencePipelineBuilder<TResult> AddRetryPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, Action<RetryPolicyOptions<TResult>> configure);
    public static IResiliencePipelineBuilder<TResult> AddRetryPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, IConfigurationSection section);
    public static IResiliencePipelineBuilder<TResult> AddRetryPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, IConfigurationSection section, Action<RetryPolicyOptions<TResult>> configure);
    public static IResiliencePipelineBuilder<TResult> AddTimeoutPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName);
    public static IResiliencePipelineBuilder<TResult> AddTimeoutPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, Action<TimeoutPolicyOptions> configure);
    public static IResiliencePipelineBuilder<TResult> AddTimeoutPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, IConfigurationSection section);
    public static IResiliencePipelineBuilder<TResult> AddTimeoutPolicy<TResult>(this IResiliencePipelineBuilder<TResult> builder, string policyName, IConfigurationSection section, Action<TimeoutPolicyOptions> configure);
}
