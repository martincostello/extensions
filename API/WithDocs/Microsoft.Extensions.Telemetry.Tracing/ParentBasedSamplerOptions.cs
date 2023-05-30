// Assembly 'Microsoft.Extensions.Telemetry'

using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Telemetry.Tracing;

/// <summary>
/// Options for the parent based sampler.
/// </summary>
public class ParentBasedSamplerOptions
{
    /// <summary>
    /// Gets or sets the type of sampler to be used for making sampling decision for root activity.
    /// </summary>
    /// <remarks>
    /// Defaults to the <see cref="F:Microsoft.Extensions.Telemetry.Tracing.SamplerType.AlwaysOn" /> sampler.
    /// </remarks>
    public SamplerType RootSamplerType { get; set; }

    public ParentBasedSamplerOptions();
}
