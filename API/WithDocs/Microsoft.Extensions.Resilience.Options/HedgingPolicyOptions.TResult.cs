// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Resilience.Options;

/// <summary>
/// Hedging policy options.
/// </summary>
/// <typeparam name="TResult">The type of the result handled by the policy.</typeparam>
public class HedgingPolicyOptions<TResult> : HedgingPolicyOptions
{
    /// <summary>
    /// Gets or sets the predicate to filter results the policy will handle.
    /// </summary>
    /// <remarks>
    /// By default, it will not retry any final result.
    /// </remarks>
    [Required]
    public Predicate<TResult> ShouldHandleResultAsError { get; set; }

    /// <summary>
    /// Gets or sets the action to call asynchronously before invoking the hedging delegate.
    /// </summary>
    [Required]
    public new Func<HedgingTaskArguments<TResult>, Task> OnHedgingAsync { get; set; }

    public HedgingPolicyOptions();
}
