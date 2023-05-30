// Assembly 'Microsoft.Extensions.Telemetry'

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using OpenTelemetry.Metrics;

namespace Microsoft.Extensions.Telemetry.Metering;

/// <summary>
/// Metering extensions for OpenTelemetry based metrics.
/// </summary>
[System.Diagnostics.CodeAnalysis.Experimental]
public static class OTelMeteringExtensions
{
    /// <summary>
    /// Extension to configure metering.
    /// </summary>
    /// <param name="builder"><see cref="T:OpenTelemetry.Metrics.MeterProviderBuilder" /> instance.</param>
    /// <param name="configurationSection">Configuration section that contains <see cref="T:Microsoft.Extensions.Telemetry.Metering.MeteringOptions" />.</param>
    /// <returns>Returns <see cref="T:OpenTelemetry.Metrics.MeterProviderBuilder" /> for chaining.</returns>
    /// <exception cref="T:System.InvalidOperationException">When the extension is called without hosting package.</exception>
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static MeterProviderBuilder AddMetering(this MeterProviderBuilder builder, IConfigurationSection configurationSection);

    /// <summary>
    /// Extension to configure metering.
    /// </summary>
    /// <param name="builder"><see cref="T:OpenTelemetry.Metrics.MeterProviderBuilder" /> instance.</param>
    /// <param name="configure">The <see cref="T:Microsoft.Extensions.Telemetry.Metering.MeteringOptions" /> configuration delegate.</param>
    /// <returns>Returns <see cref="T:OpenTelemetry.Metrics.MeterProviderBuilder" /> for chaining.</returns>
    /// <exception cref="T:System.InvalidOperationException">When the extension is called without hosting package.</exception>
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static MeterProviderBuilder AddMetering(this MeterProviderBuilder builder, Action<MeteringOptions>? configure = null);
}
