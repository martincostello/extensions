// Assembly 'Microsoft.Extensions.Telemetry.Testing'

using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Extensions.Telemetry.Testing.Metering;

/// <summary>
/// The helper class to automatically capture metering information that has been recorded
/// by instruments created by <see cref="T:System.Diagnostics.Metrics.Meter" />.
/// </summary>
/// <remarks>
/// This type has been designed to be used only for testing purposes.
/// </remarks>
/// <typeparam name="TMeterName">The type whose name is used as the <see cref="T:System.Diagnostics.Metrics.Meter" /> instance name.</typeparam>
[System.Diagnostics.CodeAnalysis.Experimental]
public sealed class MetricCollector<TMeterName> : MetricCollector
{
    /// <summary>
    /// Initializes a new instance of the <see cref="T:Microsoft.Extensions.Telemetry.Testing.Metering.MetricCollector`1" /> class.
    /// </summary>
    public MetricCollector();
}
