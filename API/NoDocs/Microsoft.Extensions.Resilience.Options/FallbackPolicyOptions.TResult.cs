// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Resilience.Options;

public class FallbackPolicyOptions<TResult> : FallbackPolicyOptions
{
    [Required]
    public Predicate<TResult> ShouldHandleResultAsError { get; set; }
    [Required]
    public new Func<FallbackTaskArguments<TResult>, Task> OnFallbackAsync { get; set; }
    public FallbackPolicyOptions();
}
