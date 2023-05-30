// Assembly 'Microsoft.Extensions.Http.Resilience'

using System;
using System.Net.Http;
using Microsoft.Extensions.Resilience.Options;

namespace Microsoft.Extensions.Http.Resilience;

public static class HttpClientResilienceGenerators
{
    public static readonly Func<RetryDelayArguments<HttpResponseMessage>, TimeSpan> HandleRetryAfterHeader;
}
