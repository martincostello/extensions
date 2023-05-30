// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.Extensions.Resilience.Options;

/// <summary>
/// Circuit breaker policy options.
/// </summary>
/// <typeparam name="TResult">The type of the result handled by the policy.</typeparam>
public class CircuitBreakerPolicyOptions<TResult> : CircuitBreakerPolicyOptions
{
    /// <summary>
    /// Gets or sets the predicate which defines the results which are treated as transient errors.
    /// </summary>
    /// <remarks>
    /// By default, it will not retry any final result.
    /// </remarks>
    public Predicate<TResult> ShouldHandleResultAsError { get; set; }

    /// <summary>
    /// Gets or sets the action performed when the circuit breaker breaks.
    /// </summary>
    [Required]
    public new Action<BreakActionArguments<TResult>> OnCircuitBreak { get; set; }

    public CircuitBreakerPolicyOptions();
}
