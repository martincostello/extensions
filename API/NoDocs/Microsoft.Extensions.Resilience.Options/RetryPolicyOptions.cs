// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Shared.Data.Validation;

namespace Microsoft.Extensions.Resilience.Options;

public class RetryPolicyOptions
{
    public const int InfiniteRetry = -1;
    [Range(-1, 100)]
    public int RetryCount { get; set; }
    public BackoffType BackoffType { get; set; }
    [TimeSpan(0, 86400000)]
    public TimeSpan BaseDelay { get; set; }
    [Required]
    public Predicate<Exception> ShouldHandleException { get; set; }
    [Required]
    public Func<RetryActionArguments, Task> OnRetryAsync { get; set; }
    public RetryPolicyOptions();
}
