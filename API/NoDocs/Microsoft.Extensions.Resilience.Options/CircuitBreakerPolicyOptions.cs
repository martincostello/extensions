// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.Shared.Data.Validation;

namespace Microsoft.Extensions.Resilience.Options;

public class CircuitBreakerPolicyOptions
{
    [ExclusiveRange(0.0, 1.0)]
    public double FailureThreshold { get; set; }
    [ExclusiveRange(1, int.MaxValue)]
    public int MinimumThroughput { get; set; }
    [TimeSpan(500, Exclusive = true)]
    public TimeSpan BreakDuration { get; set; }
    [TimeSpan(500, Exclusive = true)]
    public TimeSpan SamplingDuration { get; set; }
    public Predicate<Exception> ShouldHandleException { get; set; }
    [Required]
    public Action<ResetActionArguments> OnCircuitReset { get; set; }
    [Required]
    public Action<BreakActionArguments> OnCircuitBreak { get; set; }
    public CircuitBreakerPolicyOptions();
}
