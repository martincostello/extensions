// Assembly 'Microsoft.Extensions.Resilience'

using System.Runtime.CompilerServices;
using System.Threading;
using Polly;

namespace Microsoft.Extensions.Resilience.Options;

public readonly struct ResetActionArguments : IPolicyEventArguments
{
    public Context Context { get; }
    public CancellationToken CancellationToken { get; }
    public ResetActionArguments(Context context, CancellationToken cancellationToken);
}
