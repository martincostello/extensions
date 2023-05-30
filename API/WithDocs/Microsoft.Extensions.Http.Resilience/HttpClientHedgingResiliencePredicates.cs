// Assembly 'Microsoft.Extensions.Http.Resilience'

using System;

namespace Microsoft.Extensions.Http.Resilience;

/// <summary>
/// Static predicates used within the current package.
/// </summary>
public static class HttpClientHedgingResiliencePredicates
{
    /// <summary>
    /// Determines whether an exception should be treated by hedging as a transient failure.
    /// </summary>
    public static readonly Predicate<Exception> IsTransientHttpException;
}
