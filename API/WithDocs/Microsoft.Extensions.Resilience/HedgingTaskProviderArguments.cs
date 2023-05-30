// Assembly 'Microsoft.Extensions.Resilience'

using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Extensions.Resilience.Options;
using Polly;

namespace Microsoft.Extensions.Resilience;

/// <summary>
/// A wrapper that holds current request's <see cref="T:Polly.Context" />
/// and the current hedging attempt number.
/// </summary>
public readonly struct HedgingTaskProviderArguments : IPolicyEventArguments
{
    /// <summary>
    /// Gets the hedging attempt number.
    /// </summary>
    /// <remarks>The attempt number starts with the 1 as <see cref="T:Microsoft.Extensions.Resilience.Options.HedgingDelayArguments" /> is used after the primary hedging attempt is executed.</remarks>
    public int AttemptNumber { get; }

    /// <summary>
    /// Gets the Polly <see cref="T:Polly.Context" /> associated with the policy execution.
    /// </summary>
    public Context Context { get; }

    /// <summary>
    /// Gets the cancellation token associated with the policy execution.
    /// </summary>
    public CancellationToken CancellationToken { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Microsoft.Extensions.Resilience.HedgingTaskProviderArguments" /> struct.
    /// </summary>
    /// <param name="context">Current request's context.</param>
    /// <param name="attemptNumber">Count of already executed hedging attempts.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    public HedgingTaskProviderArguments(Context context, int attemptNumber, CancellationToken cancellationToken);
}
