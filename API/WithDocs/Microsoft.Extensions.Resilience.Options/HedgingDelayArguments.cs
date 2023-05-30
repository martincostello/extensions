// Assembly 'Microsoft.Extensions.Resilience'

using System.Runtime.CompilerServices;
using System.Threading;
using Polly;

namespace Microsoft.Extensions.Resilience.Options;

/// <summary>
/// Structure with the arguments used by <see cref="P:Microsoft.Extensions.Resilience.Options.HedgingPolicyOptions.HedgingDelayGenerator" />.
/// </summary>
public readonly struct HedgingDelayArguments : IPolicyEventArguments
{
    /// <summary>
    /// Gets the zero-based hedging attempt number.
    /// </summary>
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
    /// Initializes a new instance of the <see cref="T:Microsoft.Extensions.Resilience.Options.HedgingDelayArguments" /> structure.
    /// </summary>
    /// <param name="context">The policy context.</param>
    /// <param name="attemptNumber">The attempt number.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    public HedgingDelayArguments(Context context, int attemptNumber, CancellationToken cancellationToken);
}
