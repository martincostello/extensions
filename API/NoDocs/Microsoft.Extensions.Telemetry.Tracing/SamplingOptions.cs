// Assembly 'Microsoft.Extensions.Telemetry'

using System.Runtime.CompilerServices;
using Microsoft.Extensions.Options.Validation;

namespace Microsoft.Extensions.Telemetry.Tracing;

public class SamplingOptions
{
    public SamplerType SamplerType { get; set; }
    public ParentBasedSamplerOptions? ParentBasedSamplerOptions { get; set; }
    [ValidateObjectMembers]
    public TraceIdRatioBasedSamplerOptions? TraceIdRatioBasedSamplerOptions { get; set; }
    public SamplingOptions();
}
