// Assembly 'Microsoft.Extensions.Telemetry'

using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Telemetry.Enrichment;

/// <summary>
/// Options for the service metric enricher.
/// </summary>
public class ServiceMetricEnricherOptions
{
    /// <summary>
    /// Gets or sets a value indicating whether <see cref="P:Microsoft.Extensions.AmbientMetadata.ApplicationMetadata.EnvironmentName" /> is used for metric enrichment.
    /// </summary>
    /// <remarks>
    /// Default set to <see langword="true" />.
    /// </remarks>
    public bool EnvironmentName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="P:Microsoft.Extensions.AmbientMetadata.ApplicationMetadata.ApplicationName" /> is used for metric enrichment.
    /// </summary>
    /// <remarks>
    /// Default set to <see langword="true" />.
    /// </remarks>
    public bool ApplicationName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="P:Microsoft.Extensions.AmbientMetadata.ApplicationMetadata.DeploymentRing" /> is used for metric enrichment.
    /// </summary>
    /// <remarks>
    /// Default set to <see langword="false" />.
    /// </remarks>
    public bool DeploymentRing { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="P:Microsoft.Extensions.AmbientMetadata.ApplicationMetadata.BuildVersion" /> is used for metric enrichment.
    /// </summary>
    /// <remarks>
    /// Default set to <see langword="false" />.
    /// </remarks>
    public bool BuildVersion { get; set; }

    public ServiceMetricEnricherOptions();
}
