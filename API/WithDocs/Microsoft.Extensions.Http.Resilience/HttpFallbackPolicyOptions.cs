// Assembly 'Microsoft.Extensions.Http.Resilience'

using System.Net.Http;
using Microsoft.Extensions.Resilience.Options;

namespace Microsoft.Extensions.Http.Resilience;

/// <summary>
/// Implementation of the <see cref="T:Microsoft.Extensions.Resilience.Options.FallbackPolicyOptions`1" /> for <see cref="T:System.Net.Http.HttpResponseMessage" /> results.
/// </summary>
public class HttpFallbackPolicyOptions : FallbackPolicyOptions<HttpResponseMessage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="T:Microsoft.Extensions.Http.Resilience.HttpFallbackPolicyOptions" /> class.
    /// </summary>
    /// <remarks>
    /// By default the options is set to handle only transient failures,
    /// i.e. timeouts, 5xx responses and <see cref="T:System.Net.Http.HttpRequestException" /> exceptions.
    /// </remarks>
    public HttpFallbackPolicyOptions();
}
