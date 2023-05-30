// Assembly 'Microsoft.Extensions.Http.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Options.Validation;

namespace Microsoft.Extensions.Http.Resilience;

public class HedgingEndpointOptions
{
    [Required]
    [ValidateObjectMembers]
    public HttpBulkheadPolicyOptions BulkheadOptions { get; set; }
    [Required]
    [ValidateObjectMembers]
    public HttpCircuitBreakerPolicyOptions CircuitBreakerOptions { get; set; }
    [Required]
    [ValidateObjectMembers]
    public HttpTimeoutPolicyOptions TimeoutOptions { get; set; }
    public HedgingEndpointOptions();
}
