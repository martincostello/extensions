// Assembly 'Microsoft.Extensions.Http.Resilience'

using System.Net.Http;
using Microsoft.Extensions.Resilience.Options;

namespace Microsoft.Extensions.Http.Resilience;

/// <summary>
/// Implementation of the <see cref="T:Microsoft.Extensions.Resilience.Options.RetryPolicyOptions`1" /> for <see cref="T:System.Net.Http.HttpResponseMessage" /> results.
/// </summary>
public class HttpRetryPolicyOptions : RetryPolicyOptions<HttpResponseMessage>
{
    /// <summary>
    /// Gets or sets a value indicating whether should retry after header.
    /// </summary>
    /// <remarks>
    /// By default the property is set to <c>false</c>.
    /// If the property is set to <c>true</c>, then the DelayGenerator will maximize
    /// based on the RetryAfter header rules, otherwise it will remain null.
    /// </remarks>
    public bool ShouldRetryAfterHeader { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Microsoft.Extensions.Http.Resilience.HttpRetryPolicyOptions" /> class.
    /// </summary>
    /// <remarks>
    /// By default the options is set to handle only transient failures,
    /// i.e. timeouts, 5xx responses and <see cref="T:System.Net.Http.HttpRequestException" /> exceptions.
    /// </remarks>
    public HttpRetryPolicyOptions();
}
