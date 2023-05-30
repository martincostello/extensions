// Assembly 'Microsoft.Extensions.Http.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Options.Validation;

namespace Microsoft.Extensions.Http.Resilience;

public class HttpStandardResilienceOptions
{
    [Required]
    [ValidateObjectMembers]
    public HttpBulkheadPolicyOptions BulkheadOptions { get; set; }
    [Required]
    [ValidateObjectMembers]
    public HttpTimeoutPolicyOptions TotalRequestTimeoutOptions { get; set; }
    [Required]
    [ValidateObjectMembers]
    public HttpRetryPolicyOptions RetryOptions { get; set; }
    [Required]
    [ValidateObjectMembers]
    public HttpCircuitBreakerPolicyOptions CircuitBreakerOptions { get; set; }
    [Required]
    [ValidateObjectMembers]
    public HttpTimeoutPolicyOptions AttemptTimeoutOptions { get; set; }
    public HttpStandardResilienceOptions();
}
