// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Resilience.Options;

public class BulkheadPolicyOptions
{
    [Range(1, 10000)]
    public int MaxConcurrency { get; set; }
    [Range(0, 10000)]
    public int MaxQueuedActions { get; set; }
    [Required]
    public Func<BulkheadTaskArguments, Task> OnBulkheadRejectedAsync { get; set; }
    public BulkheadPolicyOptions();
}
