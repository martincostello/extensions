// Assembly 'Microsoft.Extensions.Diagnostics.HealthChecks.Core'

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Diagnostics.HealthChecks;

/// <summary>
/// Options to control the Kubernetes health status publisher.
/// </summary>
public class KubernetesHealthCheckPublisherOptions
{
    /// <summary>
    /// Gets or sets the TCP port which gets opened if the application is healthy and closed otherwise.
    /// </summary>
    /// <remarks>
    /// Default set to 2305.
    /// </remarks>
    [Range(1, 65535)]
    public int TcpPort { get; set; }

    /// <summary>
    /// Gets or sets the maximum length of the pending connections queue.
    /// </summary>
    /// <remarks>
    /// Default set to 10.
    /// </remarks>
    [Range(1, 10000)]
    public int MaxPendingConnections { get; set; }

    public KubernetesHealthCheckPublisherOptions();
}
