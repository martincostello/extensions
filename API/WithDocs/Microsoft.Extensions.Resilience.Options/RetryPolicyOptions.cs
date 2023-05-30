// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Shared.Data.Validation;

namespace Microsoft.Extensions.Resilience.Options;

/// <summary>
/// Retry policy options.
/// </summary>
public class RetryPolicyOptions
{
    /// <summary>
    /// Magic value representing infinite retries.
    /// </summary>
    public const int InfiniteRetry = -1;

    /// <summary>
    /// Gets or sets the maximum number of retries to use, in addition to the original call.
    /// </summary>
    /// <remarks>
    /// For infinite retries use <c>InfiniteRetry</c> (-1).
    /// </remarks>
    [Range(-1, 100)]
    public int RetryCount { get; set; }

    /// <summary>
    /// Gets or sets the type of the back-off.
    /// </summary>
    /// <remarks>
    /// Default set to <see cref="F:Microsoft.Extensions.Resilience.Options.BackoffType.ExponentialWithJitter" />.
    /// </remarks>
    public BackoffType BackoffType { get; set; }

    /// <summary>
    /// Gets or sets the delay between retries based on the backoff type, <see cref="T:Microsoft.Extensions.Resilience.Options.BackoffType" />.
    /// </summary>
    /// <remarks>
    /// Default set to 2 seconds.
    /// For <see cref="F:Microsoft.Extensions.Resilience.Options.BackoffType.ExponentialWithJitter" /> this represents the median delay to target before the first retry.
    /// For the <see cref="F:Microsoft.Extensions.Resilience.Options.BackoffType.Linear" /> it represents the initial delay, the following delays increasing linearly with this value.
    /// In case of <see cref="F:Microsoft.Extensions.Resilience.Options.BackoffType.Constant" /> it represents the constant delay between retries.
    /// </remarks>
    [TimeSpan(0, 86400000)]
    public TimeSpan BaseDelay { get; set; }

    /// <summary>
    /// Gets or sets the predicate which filters the type of exception the policy can handle.
    /// </summary>
    /// <remarks>
    /// By default any exception will be retried.
    /// </remarks>
    [Required]
    public Predicate<Exception> ShouldHandleException { get; set; }

    /// <summary>
    /// Gets or sets the action performed during the retry attempt of the retry policy.
    /// </summary>
    [Required]
    public Func<RetryActionArguments, Task> OnRetryAsync { get; set; }

    public RetryPolicyOptions();
}
