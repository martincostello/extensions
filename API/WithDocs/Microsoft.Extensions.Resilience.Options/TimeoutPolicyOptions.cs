// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Shared.Data.Validation;
using Polly.Timeout;

namespace Microsoft.Extensions.Resilience.Options;

/// <summary>
/// Options for the timeout policy.
/// </summary>
public class TimeoutPolicyOptions
{
    /// <summary>
    /// Gets or sets the timeout interval.
    /// </summary>
    /// <remarks>
    /// Default set to 30 seconds.
    /// </remarks>
    [TimeSpan(0, Exclusive = true)]
    public TimeSpan TimeoutInterval { get; set; }

    /// <summary>
    /// Gets or sets the timeout strategy.
    /// </summary>
    /// <remarks>
    /// Default is set to Optimistic Timeout strategy:
    /// <see href="https://github.com/App-vNext/Polly/wiki/Timeout#optimistic-timeout" />.
    /// </remarks>
    public TimeoutStrategy TimeoutStrategy { get; set; }

    /// <summary>
    /// Gets or sets the action performed during the timeout attempt of the timeout policy.
    /// </summary>
    [Required]
    public Func<TimeoutTaskArguments, Task> OnTimedOutAsync { get; set; }

    public TimeoutPolicyOptions();
}
