// Assembly 'Microsoft.Extensions.Resilience'

using System.Runtime.CompilerServices;
using Microsoft.Extensions.Options.Validation;

namespace Microsoft.Extensions.Resilience.FaultInjection;

public class ChaosPolicyOptionsGroup
{
    [ValidateObjectMembers]
    public LatencyPolicyOptions? LatencyPolicyOptions { get; set; }
    [ValidateObjectMembers]
    public HttpResponseInjectionPolicyOptions? HttpResponseInjectionPolicyOptions { get; set; }
    [ValidateObjectMembers]
    public ExceptionPolicyOptions? ExceptionPolicyOptions { get; set; }
    public ChaosPolicyOptionsGroup();
}
