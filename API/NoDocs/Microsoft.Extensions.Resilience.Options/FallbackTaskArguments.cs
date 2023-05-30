// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Polly;

namespace Microsoft.Extensions.Resilience.Options;

public readonly struct FallbackTaskArguments : IPolicyEventArguments
{
    public Exception Exception { get; }
    public Context Context { get; }
    public CancellationToken CancellationToken { get; }
    public FallbackTaskArguments(Exception exception, Context context, CancellationToken cancellationToken);
}
