// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Polly;

namespace Microsoft.Extensions.Resilience.Options;

public readonly struct BreakActionArguments<TResult> : IPolicyEventArguments<TResult>, IPolicyEventArguments
{
    public DelegateResult<TResult> Result { get; }
    public TimeSpan BreakDuration { get; }
    public Context Context { get; }
    public CancellationToken CancellationToken { get; }
    public BreakActionArguments(DelegateResult<TResult> result, Context context, TimeSpan breakDuration, CancellationToken cancellationToken);
}
