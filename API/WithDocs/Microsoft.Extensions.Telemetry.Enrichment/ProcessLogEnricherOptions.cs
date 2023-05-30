// Assembly 'Microsoft.Extensions.Telemetry'

using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Telemetry.Enrichment;

/// <summary>
/// Options for the process enricher.
/// </summary>
public class ProcessLogEnricherOptions
{
    /// <summary>
    /// Gets or sets a value indicating whether current process ID is used for log enrichment.
    /// </summary>
    /// <remarks>
    /// Default set to <see langword="true" />.
    /// </remarks>
    public bool ProcessId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether current thread ID is used for log enrichment.
    /// </summary>
    /// <remarks>
    /// Default set to <see langword="false" />.
    /// </remarks>
    public bool ThreadId { get; set; }

    public ProcessLogEnricherOptions();
}
