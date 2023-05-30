// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Polly;

namespace Microsoft.Extensions.Resilience.Options;

/// <summary>
/// Structure with the arguments of the on retry action.
/// </summary>
/// <typeparam name="TResult">The type of the result handled by the policy.</typeparam>
public readonly struct RetryActionArguments<TResult> : IPolicyEventArguments<TResult>, IPolicyEventArguments
{
    /// <summary>
    /// Gets the result of the action executed by the retry policy.
    /// </summary>
    public DelegateResult<TResult> Result { get; }

    /// <summary>
    /// Gets the waiting time interval.
    /// </summary>
    public TimeSpan WaitingTimeInterval { get; }

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
    /// Initializes a new instance of the <see cref="T:Microsoft.Extensions.Resilience.Options.RetryActionArguments`1" /> structure.
    /// </summary>
    /// <param name="result">The result.</param>
    /// <param name="context">The policy context.</param>
    /// <param name="waitingTimeInterval">The waiting time interval.</param>
    /// <param name="attemptNumber">The attempt number.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    public RetryActionArguments(DelegateResult<TResult> result, Context context, TimeSpan waitingTimeInterval, int attemptNumber, CancellationToken cancellationToken);
}
