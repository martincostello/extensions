// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Polly;

namespace Microsoft.Extensions.Resilience.Options;

/// <summary>
/// Structure with the arguments of the on hedging task.
/// </summary>
public readonly struct HedgingTaskArguments : IPolicyEventArguments
{
    /// <summary>
    /// Gets the exception of the action executed by the retry policy.
    /// </summary>
    public Exception Exception { get; }

    /// <summary>
    /// Gets the attempt number.
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
    /// Initializes a new instance of the <see cref="T:Microsoft.Extensions.Resilience.Options.HedgingTaskArguments" /> structure.
    /// </summary>
    /// <param name="exception">The exception.</param>
    /// <param name="context">The policy context.</param>
    /// <param name="attemptNumber">The attempt number.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    public HedgingTaskArguments(Exception exception, Context context, int attemptNumber, CancellationToken cancellationToken);
}
