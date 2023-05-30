// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Resilience.Options;

public class FallbackPolicyOptions
{
    [Required]
    public Predicate<Exception> ShouldHandleException { get; set; }
    [Required]
    public Func<FallbackTaskArguments, Task> OnFallbackAsync { get; set; }
    public FallbackPolicyOptions();
}
