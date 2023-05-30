// Assembly 'Microsoft.Extensions.Resilience'

using System.Runtime.CompilerServices;
using System.Threading;
using Polly;

namespace Microsoft.Extensions.Resilience.Options;

public readonly struct HedgingDelayArguments : IPolicyEventArguments
{
    public int AttemptNumber { get; }
    public Context Context { get; }
    public CancellationToken CancellationToken { get; }
    public HedgingDelayArguments(Context context, int attemptNumber, CancellationToken cancellationToken);
}
