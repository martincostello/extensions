// Assembly 'Microsoft.Extensions.Http.Resilience'

using System;
using System.Net.Http;
using Microsoft.Extensions.Resilience.Options;

namespace Microsoft.Extensions.Http.Resilience;

/// <summary>
/// Static generators used within the current package.
/// </summary>
public static class HttpClientResilienceGenerators
{
    /// <summary>
    /// Gets the generator that is able to generate delay based on the "Retry-After" response header.
    /// </summary>
    public static readonly Func<RetryDelayArguments<HttpResponseMessage>, TimeSpan> HandleRetryAfterHeader;
}
