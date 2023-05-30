// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Resilience.Options;

public class RetryPolicyOptions<TResult> : RetryPolicyOptions
{
    [Required]
    public Predicate<TResult> ShouldHandleResultAsError { get; set; }
    [Required]
    public new Func<RetryActionArguments<TResult>, Task> OnRetryAsync { get; set; }
    public Func<RetryDelayArguments<TResult>, TimeSpan>? RetryDelayGenerator { get; set; }
    public RetryPolicyOptions();
}
