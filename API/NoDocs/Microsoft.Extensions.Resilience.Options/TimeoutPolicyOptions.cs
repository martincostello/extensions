// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Shared.Data.Validation;
using Polly.Timeout;

namespace Microsoft.Extensions.Resilience.Options;

public class TimeoutPolicyOptions
{
    [TimeSpan(0, Exclusive = true)]
    public TimeSpan TimeoutInterval { get; set; }
    public TimeoutStrategy TimeoutStrategy { get; set; }
    [Required]
    public Func<TimeoutTaskArguments, Task> OnTimedOutAsync { get; set; }
    public TimeoutPolicyOptions();
}
