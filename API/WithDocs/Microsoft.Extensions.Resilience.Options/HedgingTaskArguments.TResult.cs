// Assembly 'Microsoft.Extensions.Resilience'

using System.Runtime.CompilerServices;
using System.Threading;
using Polly;

namespace Microsoft.Extensions.Resilience.Options;

/// <summary>
/// Structure with the arguments of the on hedging task.
/// </summary>
/// <typeparam name="TResult">The type of the result handled by the policy.</typeparam>
public readonly struct HedgingTaskArguments<TResult> : IPolicyEventArguments<TResult>, IPolicyEventArguments
{
    /// <summary>
    /// Gets the result of the action executed by the retry policy.
    /// </summary>
    public DelegateResult<TResult> Result { get; }

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
    /// Initializes a new instance of the <see cref="T:Microsoft.Extensions.Resilience.Options.HedgingTaskArguments`1" /> structure.
    /// </summary>
    /// <param name="result">The result.</param>
    /// <param name="context">The policy context.</param>
    /// <param name="attemptNumber">The attempt number.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    public HedgingTaskArguments(DelegateResult<TResult> result, Context context, int attemptNumber, CancellationToken cancellationToken);
}
