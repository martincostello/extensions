// Assembly 'Microsoft.AspNetCore.Telemetry.Middleware'

using System;
using System.Runtime.CompilerServices;
using Microsoft.Shared.Data.Validation;

namespace Microsoft.AspNetCore.Telemetry;

/// <summary>
/// Options to configure the request latency middleware.
/// </summary>
public class RequestLatencyTelemetryOptions
{
    /// <summary>
    /// Gets or sets the amount of time to wait for export of latency data.
    /// </summary>
    /// <remarks>
    /// Default set to 5 seconds.
    /// </remarks>
    [TimeSpan(1000)]
    public TimeSpan LatencyDataExportTimeout { get; set; }

    public RequestLatencyTelemetryOptions();
}
