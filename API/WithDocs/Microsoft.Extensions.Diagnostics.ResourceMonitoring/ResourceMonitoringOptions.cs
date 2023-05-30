// Assembly 'Microsoft.Extensions.Diagnostics.ResourceMonitoring'

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Microsoft.Shared.Data.Validation;

namespace Microsoft.Extensions.Diagnostics.ResourceMonitoring;

/// <summary>
/// Options for <see cref="T:Microsoft.Extensions.Diagnostics.ResourceMonitoring.IResourceMonitor" />.
/// </summary>
public class ResourceMonitoringOptions
{
    /// <summary>
    /// Gets or sets the maximum time window for which utilization can be requested.
    /// </summary>
    /// <remarks>
    /// Default set to 5 seconds.
    /// </remarks>
    [TimeSpan(100, 900000)]
    public TimeSpan CollectionWindow { get; set; }

    /// <summary>
    /// Gets or sets the interval at which a new utilization sample is captured.
    /// </summary>
    /// <remarks>
    /// Default set to 1 second.
    /// </remarks>
    [TimeSpan(1, 900000)]
    public TimeSpan SamplingInterval { get; set; }

    /// <summary>
    /// Gets or sets the default period used for utilization calculation.
    /// </summary>
    /// <remarks>
    /// Default set to 5 seconds. The value needs to be less than or equal to the <see cref="P:Microsoft.Extensions.Diagnostics.ResourceMonitoring.ResourceMonitoringOptions.CollectionWindow" />.
    /// Most importantly, this period is used to calculate <see cref="T:Microsoft.Extensions.Diagnostics.ResourceMonitoring.Utilization" /> instances pushed to publishers.
    /// </remarks>
    [System.Diagnostics.CodeAnalysis.Experimental]
    [TimeSpan(100, 900000)]
    public TimeSpan CalculationPeriod { get; set; }

    public ResourceMonitoringOptions();
}
