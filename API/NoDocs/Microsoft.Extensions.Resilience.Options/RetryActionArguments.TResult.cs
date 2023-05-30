// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Polly;

namespace Microsoft.Extensions.Resilience.Options;

public readonly struct RetryActionArguments<TResult> : IPolicyEventArguments<TResult>, IPolicyEventArguments
{
    public DelegateResult<TResult> Result { get; }
    public TimeSpan WaitingTimeInterval { get; }
    public int AttemptNumber { get; }
    public Context Context { get; }
    public CancellationToken CancellationToken { get; }
    public RetryActionArguments(DelegateResult<TResult> result, Context context, TimeSpan waitingTimeInterval, int attemptNumber, CancellationToken cancellationToken);
}
