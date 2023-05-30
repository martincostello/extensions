// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Shared.Data.Validation;

namespace Microsoft.Extensions.Resilience.Options;

public class HedgingPolicyOptions
{
    public static readonly TimeSpan InfiniteHedgingDelay;
    [TimeSpan(-1, Exclusive = false)]
    public TimeSpan HedgingDelay { get; set; }
    public Func<HedgingDelayArguments, TimeSpan>? HedgingDelayGenerator { get; set; }
    [Range(2, 10)]
    public int MaxHedgedAttempts { get; set; }
    [Required]
    public Predicate<Exception> ShouldHandleException { get; set; }
    [Required]
    public Func<HedgingTaskArguments, Task> OnHedgingAsync { get; set; }
    public HedgingPolicyOptions();
}
