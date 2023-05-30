// Assembly 'Microsoft.Extensions.Http.Resilience'

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Options.Validation;

namespace Microsoft.Extensions.Http.Resilience;

public class HttpStandardHedgingResilienceOptions
{
    [Required]
    [ValidateObjectMembers]
    public HttpTimeoutPolicyOptions TotalRequestTimeoutOptions { get; set; }
    [Required]
    [ValidateObjectMembers]
    public HttpHedgingPolicyOptions HedgingOptions { get; set; }
    [Required]
    [ValidateObjectMembers]
    public HedgingEndpointOptions EndpointOptions { get; set; }
    public HttpStandardHedgingResilienceOptions();
}
