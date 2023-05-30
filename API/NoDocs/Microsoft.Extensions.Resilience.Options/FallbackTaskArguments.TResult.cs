// Assembly 'Microsoft.Extensions.Resilience'

using System.Runtime.CompilerServices;
using System.Threading;
using Polly;

namespace Microsoft.Extensions.Resilience.Options;

public readonly struct FallbackTaskArguments<TResult> : IPolicyEventArguments<TResult>, IPolicyEventArguments
{
    public DelegateResult<TResult> Result { get; }
    public Context Context { get; }
    public CancellationToken CancellationToken { get; }
    public FallbackTaskArguments(DelegateResult<TResult> result, Context context, CancellationToken cancellationToken);
}
