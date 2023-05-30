// Assembly 'Microsoft.Extensions.Telemetry'

using System.Runtime.CompilerServices;
using Microsoft.Extensions.Options.Validation;

namespace Microsoft.Extensions.Telemetry.Tracing;

/// <summary>
/// Options for sampling.
/// </summary>
public class SamplingOptions
{
    /// <summary>
    /// Gets or sets the type of the sampler.
    /// </summary>
    /// <remarks>
    /// Defaults to the <see cref="F:Microsoft.Extensions.Telemetry.Tracing.SamplerType.AlwaysOn" /> sampler.
    /// </remarks>
    public SamplerType SamplerType { get; set; }

    /// <summary>
    /// Gets or sets options for the parent based sampler.
    /// </summary>
    /// <remarks>
    /// Defaults to <see langword="null" />.
    /// </remarks>
    public ParentBasedSamplerOptions? ParentBasedSamplerOptions { get; set; }

    /// <summary>
    /// Gets or sets options for the trace Id ratio based sampler.
    /// </summary>
    /// <remarks>
    /// Defaults to <see langword="null" />.
    /// </remarks>
    [ValidateObjectMembers]
    public TraceIdRatioBasedSamplerOptions? TraceIdRatioBasedSamplerOptions { get; set; }

    public SamplingOptions();
}
