// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.Extensions.Resilience.Options;

public class CircuitBreakerPolicyOptions<TResult> : CircuitBreakerPolicyOptions
{
    public Predicate<TResult> ShouldHandleResultAsError { get; set; }
    [Required]
    public new Action<BreakActionArguments<TResult>> OnCircuitBreak { get; set; }
    public CircuitBreakerPolicyOptions();
}
