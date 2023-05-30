// Assembly 'Microsoft.Extensions.Telemetry'

using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Telemetry.Latency;

/// <summary>
/// Options for LatencyContext.
/// </summary>
public class LatencyContextOptions
{
    /// <summary>
    /// Gets or sets a value indicating whether exception is thrown when using unregistered names.
    /// </summary>
    /// <remarks>The ILatencyContext APIs throws when using unregistred names if true.
    /// Becomes no-op otherwise. Defaults to false.</remarks>
    public bool ThrowOnUnregisteredNames { get; set; }

    public LatencyContextOptions();
}
