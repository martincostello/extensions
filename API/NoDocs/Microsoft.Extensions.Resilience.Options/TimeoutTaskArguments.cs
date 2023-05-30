// Assembly 'Microsoft.Extensions.Resilience'

using System.Runtime.CompilerServices;
using System.Threading;
using Polly;

namespace Microsoft.Extensions.Resilience.Options;

public readonly struct TimeoutTaskArguments : IPolicyEventArguments
{
    public Context Context { get; }
    public CancellationToken CancellationToken { get; }
    public TimeoutTaskArguments(Context context, CancellationToken cancellationToken);
}
