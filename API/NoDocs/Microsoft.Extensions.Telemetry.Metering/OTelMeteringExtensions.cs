// Assembly 'Microsoft.Extensions.Telemetry'

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using OpenTelemetry.Metrics;

namespace Microsoft.Extensions.Telemetry.Metering;

[System.Diagnostics.CodeAnalysis.Experimental]
public static class OTelMeteringExtensions
{
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static MeterProviderBuilder AddMetering(this MeterProviderBuilder builder, IConfigurationSection configurationSection);
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static MeterProviderBuilder AddMetering(this MeterProviderBuilder builder, Action<MeteringOptions>? configure = null);
}
