// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Resilience.Options;

/// <summary>
/// Options for the bulkhead policy.
/// </summary>
public class BulkheadPolicyOptions
{
    /// <summary>
    /// Gets or sets the maximum parallelization of executions through the bulkhead.
    /// </summary>
    /// <remarks>
    /// Default set to 1000.
    /// </remarks>
    [Range(1, 10000)]
    public int MaxConcurrency { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of actions that may be queued (waiting to acquire an execution slot) at any one time.
    /// </summary>
    /// <remarks>
    /// Default set to 0.
    /// </remarks>
    [Range(0, 10000)]
    public int MaxQueuedActions { get; set; }

    /// <summary>
    /// Gets or sets the action performed during the bulkhead rejection of the bulkhead policy.
    /// </summary>
    [Required]
    public Func<BulkheadTaskArguments, Task> OnBulkheadRejectedAsync { get; set; }

    public BulkheadPolicyOptions();
}
