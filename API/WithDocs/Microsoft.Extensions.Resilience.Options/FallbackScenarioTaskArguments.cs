// Assembly 'Microsoft.Extensions.Resilience'

using System.Runtime.CompilerServices;
using System.Threading;
using Polly;

namespace Microsoft.Extensions.Resilience.Options;

/// <summary>
/// Structure with the arguments of the on bulkhead task.
/// </summary>
public readonly struct FallbackScenarioTaskArguments : IPolicyEventArguments
{
    /// <summary>
    /// Gets the Polly <see cref="T:Polly.Context" /> associated with the policy execution.
    /// </summary>
    public Context Context { get; }

    /// <summary>
    /// Gets the cancellation token associated with the policy execution.
    /// </summary>
    public CancellationToken CancellationToken { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Microsoft.Extensions.Resilience.Options.FallbackScenarioTaskArguments" /> structure.
    /// </summary>
    /// <param name="context">The policy context.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    public FallbackScenarioTaskArguments(Context context, CancellationToken cancellationToken);
}
