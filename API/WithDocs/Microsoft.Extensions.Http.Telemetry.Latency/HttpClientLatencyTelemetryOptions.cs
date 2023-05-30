// Assembly 'Microsoft.Extensions.Http.Telemetry'

using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Http.Telemetry.Latency;

/// <summary>
/// Options to configure the http client latency telemetry.
/// </summary>
public class HttpClientLatencyTelemetryOptions
{
    /// <summary>
    /// Gets or sets a value indicating whether to collect detailed latency breakdown of <see cref="T:System.Net.Http.HttpClient" /> call.
    /// </summary>
    /// <remarks>
    /// Detailed breakdowns add checkpoints for HTTP operations such as connection open, request headers sent etc.
    /// Defaults to <see langword="true" />.
    /// </remarks>
    public bool EnableDetailedLatencyBreadkdown { get; set; }

    public HttpClientLatencyTelemetryOptions();
}
