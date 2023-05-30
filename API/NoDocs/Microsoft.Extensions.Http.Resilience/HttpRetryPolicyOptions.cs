// Assembly 'Microsoft.Extensions.Http.Resilience'

using System.Net.Http;
using Microsoft.Extensions.Resilience.Options;

namespace Microsoft.Extensions.Http.Resilience;

public class HttpRetryPolicyOptions : RetryPolicyOptions<HttpResponseMessage>
{
    public bool ShouldRetryAfterHeader { get; set; }
    public HttpRetryPolicyOptions();
}
