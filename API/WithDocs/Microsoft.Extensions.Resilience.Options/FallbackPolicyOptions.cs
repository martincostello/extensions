// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Resilience.Options;

/// <summary>
/// Options for the fallback policy.
/// </summary>
public class FallbackPolicyOptions
{
    /// <summary>
    /// Gets or sets the exception predicate to filter the type of exception the policy can handle.
    /// </summary>
    /// <remarks>
    /// By default any exception will be retried.
    /// </remarks>
    [Required]
    public Predicate<Exception> ShouldHandleException { get; set; }

    /// <summary>
    /// Gets or sets the action to call asynchronously before invoking the task performed in the fallback scenario,
    /// after the initially executed action encounters a transient failure.
    /// </summary>
    [Required]
    public Func<FallbackTaskArguments, Task> OnFallbackAsync { get; set; }

    public FallbackPolicyOptions();
}
