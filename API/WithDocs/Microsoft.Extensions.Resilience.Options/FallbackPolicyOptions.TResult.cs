// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Resilience.Options;

/// <summary>
/// Options for the fallback policy.
/// </summary>
/// <typeparam name="TResult">The type of the result handled by the policy.</typeparam>
public class FallbackPolicyOptions<TResult> : FallbackPolicyOptions
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
    /// Gets or sets the action to call asynchronously before invoking the task performed in the fallback scenario,
    /// after the initially executed action encounters a transient failure.
    /// </summary>
    [Required]
    public new Func<FallbackTaskArguments<TResult>, Task> OnFallbackAsync { get; set; }

    public FallbackPolicyOptions();
}
