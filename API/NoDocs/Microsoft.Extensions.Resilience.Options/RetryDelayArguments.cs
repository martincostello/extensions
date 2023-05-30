// Assembly 'Microsoft.Extensions.Resilience'

using System.Runtime.CompilerServices;
using System.Threading;
using Polly;

namespace Microsoft.Extensions.Resilience.Options;

public readonly struct RetryDelayArguments<TResult> : IPolicyEventArguments<TResult>, IPolicyEventArguments
{
    public Context Context { get; }
    public CancellationToken CancellationToken { get; }
    public DelegateResult<TResult> Result { get; }
    public RetryDelayArguments(DelegateResult<TResult> result, Context context, CancellationToken cancellationToken);
}
