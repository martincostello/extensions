// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Resilience.Options;

/// <summary>
/// Retry policy options.
/// </summary>
/// <typeparam name="TResult">The type of the result handled by the policy.</typeparam>
public class RetryPolicyOptions<TResult> : RetryPolicyOptions
{
    /// <summary>
    /// Gets or sets the predicate which defines what results shall be
    /// treated as transient error by the policy.
    /// </summary>
    /// <remarks>
    /// By default, it will not retry any final result.
    /// </remarks>
    [Required]
    public Predicate<TResult> ShouldHandleResultAsError { get; set; }

    /// <summary>
    /// Gets or sets the action performed during the retry attempt of the retry policy.
    /// </summary>
    [Required]
    public new Func<RetryActionArguments<TResult>, Task> OnRetryAsync { get; set; }

    /// <summary>
    /// Gets or sets the delegate for customizing delay for the retry policy.
    /// </summary>
    /// <remarks>
    /// By default this is null and the delay will be calculated based on the backoff type only.
    /// </remarks>
    public Func<RetryDelayArguments<TResult>, TimeSpan>? RetryDelayGenerator { get; set; }

    public RetryPolicyOptions();
}
