// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Polly;

namespace Microsoft.Extensions.Resilience.Options;

public readonly struct HedgingTaskArguments : IPolicyEventArguments
{
    public Exception Exception { get; }
    public int AttemptNumber { get; }
    public Context Context { get; }
    public CancellationToken CancellationToken { get; }
    public HedgingTaskArguments(Exception exception, Context context, int attemptNumber, CancellationToken cancellationToken);
}
