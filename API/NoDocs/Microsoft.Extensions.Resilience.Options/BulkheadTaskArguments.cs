// Assembly 'Microsoft.Extensions.Resilience'

using System.Runtime.CompilerServices;
using System.Threading;
using Polly;

namespace Microsoft.Extensions.Resilience.Options;

public readonly struct BulkheadTaskArguments : IPolicyEventArguments
{
    public Context Context { get; }
    public CancellationToken CancellationToken { get; }
    public BulkheadTaskArguments(Context context, CancellationToken cancellationToken);
}
