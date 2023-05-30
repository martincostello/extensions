// Assembly 'Microsoft.Extensions.Resilience'

using System.Runtime.CompilerServices;
using System.Threading;
using Polly;

namespace Microsoft.Extensions.Resilience.Options;

public readonly struct HedgingTaskArguments<TResult> : IPolicyEventArguments<TResult>, IPolicyEventArguments
{
    public DelegateResult<TResult> Result { get; }
    public int AttemptNumber { get; }
    public Context Context { get; }
    public CancellationToken CancellationToken { get; }
    public HedgingTaskArguments(DelegateResult<TResult> result, Context context, int attemptNumber, CancellationToken cancellationToken);
}
