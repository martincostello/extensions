// Assembly 'Microsoft.Extensions.Http.Resilience'

using System;
using System.Net.Http;

namespace Microsoft.Extensions.Http.Resilience;

public static class HttpClientResiliencePredicates
{
    public static readonly Predicate<Exception> IsTransientHttpException;
    public static readonly Predicate<HttpResponseMessage> IsTransientHttpFailure;
}
