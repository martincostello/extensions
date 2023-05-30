// Assembly 'Microsoft.Extensions.Diagnostics.HealthChecks.Core'

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Diagnostics.HealthChecks;

public class KubernetesHealthCheckPublisherOptions
{
    [Range(1, 65535)]
    public int TcpPort { get; set; }
    [Range(1, 10000)]
    public int MaxPendingConnections { get; set; }
    public KubernetesHealthCheckPublisherOptions();
}
