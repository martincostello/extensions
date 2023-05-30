// Assembly 'Microsoft.Extensions.Telemetry'

using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Telemetry.Tracing;

public class ParentBasedSamplerOptions
{
    public SamplerType RootSamplerType { get; set; }
    public ParentBasedSamplerOptions();
}
