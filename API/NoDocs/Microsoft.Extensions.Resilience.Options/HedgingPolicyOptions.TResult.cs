// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Resilience.Options;

public class HedgingPolicyOptions<TResult> : HedgingPolicyOptions
{
    [Required]
    public Predicate<TResult> ShouldHandleResultAsError { get; set; }
    [Required]
    public new Func<HedgingTaskArguments<TResult>, Task> OnHedgingAsync { get; set; }
    public HedgingPolicyOptions();
}
