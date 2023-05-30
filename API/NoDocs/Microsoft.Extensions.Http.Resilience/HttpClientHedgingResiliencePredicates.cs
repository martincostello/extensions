// Assembly 'Microsoft.Extensions.Http.Resilience'

using System;

namespace Microsoft.Extensions.Http.Resilience;

public static class HttpClientHedgingResiliencePredicates
{
    public static readonly Predicate<Exception> IsTransientHttpException;
}
