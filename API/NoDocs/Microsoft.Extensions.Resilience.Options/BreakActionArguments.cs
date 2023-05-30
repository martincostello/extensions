// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Polly;

namespace Microsoft.Extensions.Resilience.Options;

public readonly struct BreakActionArguments : IPolicyEventArguments
{
    public Exception Exception { get; }
    public TimeSpan BreakDuration { get; }
    public Context Context { get; }
    public CancellationToken CancellationToken { get; }
    public BreakActionArguments(Exception exception, Context context, TimeSpan breakDuration, CancellationToken cancellationToken);
}
