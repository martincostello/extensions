// Assembly 'Microsoft.Extensions.Diagnostics.HealthChecks.Core'

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Diagnostics.HealthChecks;

/// <summary>
/// Options for the telemetry health check publisher.
/// </summary>
[System.Diagnostics.CodeAnalysis.Experimental]
public class TelemetryHealthCheckPublisherOptions
{
    /// <summary>
    /// Gets or sets a value indicating whether to log only when unhealthy reports are received. Set to false to always log.
    /// </summary>
    /// <remarks>
    /// Default set to false.
    /// </remarks>
    [System.Diagnostics.CodeAnalysis.Experimental]
    public bool LogOnlyUnhealthy { get; set; }

    public TelemetryHealthCheckPublisherOptions();
}
