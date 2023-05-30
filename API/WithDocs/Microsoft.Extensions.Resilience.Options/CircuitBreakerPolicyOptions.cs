// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.Shared.Data.Validation;

namespace Microsoft.Extensions.Resilience.Options;

/// <summary>
/// Circuit breaker policy options.
/// </summary>
public class CircuitBreakerPolicyOptions
{
    /// <summary>
    /// Gets or sets the failure threshold.
    /// </summary>
    /// <remarks>
    /// If the ratio (between the number of failed request and total request) exceeds this threshold, the circuit will break.
    /// A ratio number higher than 0, up to 1.
    /// Default set to 0.1.
    /// </remarks>
    [ExclusiveRange(0.0, 1.0)]
    public double FailureThreshold { get; set; }

    /// <summary>
    /// Gets or sets the minimum throughput.
    /// </summary>
    /// <remarks>
    /// This defines how many actions must pass through the circuit in the time-slice,
    /// for statistics to be considered significant and the circuit-breaker to come into action.
    /// Value must be greater than one.
    /// Default set to 100.
    /// </remarks>
    [ExclusiveRange(1, int.MaxValue)]
    public int MinimumThroughput { get; set; }

    /// <summary>
    /// Gets or sets the duration of break.
    /// </summary>
    /// <remarks>
    /// The duration the circuit will stay open before resetting.
    /// Value must be greater than 0.5 seconds.
    /// Default set to 5 seconds.
    /// </remarks>
    [TimeSpan(500, Exclusive = true)]
    public TimeSpan BreakDuration { get; set; }

    /// <summary>
    /// Gets or sets the duration of the sampling.
    /// </summary>
    /// <remarks>
    /// The duration of the time-slice over which failure ratios are assessed.
    /// Value must be greater than 0.5 seconds.
    /// Default set to 30 seconds.
    /// </remarks>
    [TimeSpan(500, Exclusive = true)]
    public TimeSpan SamplingDuration { get; set; }

    /// <summary>
    /// Gets or sets the predicate which filters the type of exception the policy can handle.
    /// </summary>
    /// <remarks>
    /// By default any exception will be retried.
    /// </remarks>
    public Predicate<Exception> ShouldHandleException { get; set; }

    /// <summary>
    /// Gets or sets the action performed when the circuit breaker resets itself.
    /// </summary>
    [Required]
    public Action<ResetActionArguments> OnCircuitReset { get; set; }

    /// <summary>
    /// Gets or sets the action performed when the circuit breaker breaks.
    /// </summary>
    [Required]
    public Action<BreakActionArguments> OnCircuitBreak { get; set; }

    public CircuitBreakerPolicyOptions();
}
