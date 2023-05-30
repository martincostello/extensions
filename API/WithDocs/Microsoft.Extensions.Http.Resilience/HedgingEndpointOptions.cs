// Assembly 'Microsoft.Extensions.Http.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Options.Validation;

namespace Microsoft.Extensions.Http.Resilience;

/// <summary>
/// Options for resilient pipeline of policies assigned to a particular endpoint. It is using three chained layers in this order (from the outermost to the innermost):
/// Bulkhead -&gt; Circuit Breaker -&gt; Attempt Timeout.
/// </summary>
public class HedgingEndpointOptions
{
    /// <summary>
    /// Gets or sets the bulkhead options for the endpoint.
    /// </summary>
    /// <remarks>
    /// By default it is initialized with a unique instance of <see cref="T:Microsoft.Extensions.Http.Resilience.HttpBulkheadPolicyOptions" /> using default properties values.
    /// </remarks>
    [Required]
    [ValidateObjectMembers]
    public HttpBulkheadPolicyOptions BulkheadOptions { get; set; }

    /// <summary>
    /// Gets or sets the circuit breaker options for the endpoint.
    /// </summary>
    /// <remarks>
    /// By default it is initialized with a unique instance of <see cref="T:Microsoft.Extensions.Http.Resilience.HttpCircuitBreakerPolicyOptions" /> using default properties values.
    /// </remarks>
    [Required]
    [ValidateObjectMembers]
    public HttpCircuitBreakerPolicyOptions CircuitBreakerOptions { get; set; }

    /// <summary>
    /// Gets or sets the options for the timeout policy applied per each request attempt.
    /// </summary>
    /// <remarks>
    /// By default it is initialized with a unique instance of <see cref="T:Microsoft.Extensions.Http.Resilience.HttpTimeoutPolicyOptions" />
    /// using a custom <see cref="P:Microsoft.Extensions.Resilience.Options.TimeoutPolicyOptions.TimeoutInterval" /> of 10 seconds.
    /// </remarks>
    [Required]
    [ValidateObjectMembers]
    public HttpTimeoutPolicyOptions TimeoutOptions { get; set; }

    public HedgingEndpointOptions();
}
