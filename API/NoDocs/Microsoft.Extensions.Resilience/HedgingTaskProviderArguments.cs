// Assembly 'Microsoft.Extensions.Resilience'

using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Extensions.Resilience.Options;
using Polly;

namespace Microsoft.Extensions.Resilience;

public readonly struct HedgingTaskProviderArguments : IPolicyEventArguments
{
    public int AttemptNumber { get; }
    public Context Context { get; }
    public CancellationToken CancellationToken { get; }
    public HedgingTaskProviderArguments(Context context, int attemptNumber, CancellationToken cancellationToken);
}
