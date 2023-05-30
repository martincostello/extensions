// Assembly 'Microsoft.Extensions.Http.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Options.Validation;

namespace Microsoft.Extensions.Http.Resilience;

/// <summary>
/// Options for resilient pipeline of policies for usage in HTTP scenarios. It is using five chained layers in this order (from the outermost to the innermost):
/// Bulkhead -&gt; Total Request Timeout -&gt; Retry -&gt; Circuit Breaker -&gt; Attempt Timeout.
/// </summary>
/// /// <remarks>
/// The configuration of each policy is initialized with the default options per type. The request goes through these policies:
/// 1. Total request timeout policy applies an overall timeout to the execution, ensuring that the request including hedging attempts does not exceed the configured limit.
/// 2. The retry policy retries the request in case the dependency is slow or returns a transient error.
/// 3. The bulkhead policy limits the maximum number of concurrent requests being send to the dependency.
/// 4. The circuit breaker blocks the execution if too many direct failures or timeouts are detected.
/// 5. The attempt timeout policy limits each request attempt duration and throws if its exceeded.
/// </remarks>
public class HttpStandardResilienceOptions
{
    /// <summary>
    /// Gets or sets the bulkhead options.
    /// </summary>
    /// <remarks>
    /// By default it is initialized with a unique instance of <see cref="T:Microsoft.Extensions.Http.Resilience.HttpBulkheadPolicyOptions" /> using default properties values.
    /// </remarks>
    [Required]
    [ValidateObjectMembers]
    public HttpBulkheadPolicyOptions BulkheadOptions { get; set; }

    /// <summary>
    /// Gets or sets the timeout policy options for the total timeout applied on the request's execution.
    /// </summary>
    /// <remarks>
    /// By default it is initialized with a unique instance of <see cref="T:Microsoft.Extensions.Http.Resilience.HttpTimeoutPolicyOptions" />
    /// using default properties values.
    /// </remarks>
    [Required]
    [ValidateObjectMembers]
    public HttpTimeoutPolicyOptions TotalRequestTimeoutOptions { get; set; }

    /// <summary>
    /// Gets or sets the retry policy Options.
    /// </summary>
    /// <remarks>
    /// By default it is initialized with a unique instance of <see cref="T:Microsoft.Extensions.Http.Resilience.HttpRetryPolicyOptions" /> using default properties values.
    /// </remarks>
    [Required]
    [ValidateObjectMembers]
    public HttpRetryPolicyOptions RetryOptions { get; set; }

    /// <summary>
    /// Gets or sets the circuit breaker options.
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
    /// using custom <see cref="P:Microsoft.Extensions.Resilience.Options.TimeoutPolicyOptions.TimeoutInterval" /> of 10 seconds.
    /// </remarks>
    [Required]
    [ValidateObjectMembers]
    public HttpTimeoutPolicyOptions AttemptTimeoutOptions { get; set; }

    public HttpStandardResilienceOptions();
}
