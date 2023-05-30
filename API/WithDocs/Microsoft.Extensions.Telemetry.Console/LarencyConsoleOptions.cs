// Assembly 'Microsoft.Extensions.Telemetry.Console'

using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Telemetry.Console;

/// <summary>
/// Options for console latency data exporter.
/// </summary>
public class LarencyConsoleOptions
{
    /// <summary>
    /// Gets or sets a value indicating whether to emit latency checkpoint information to the console.
    /// </summary>
    /// <remarks>
    /// Defaults to <see langword="true" />.
    /// </remarks>
    public bool OutputCheckpoints { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to emit latency tag information to the console.
    /// </summary>
    /// <remarks>
    /// Defaults to <see langword="true" />.
    /// </remarks>
    public bool OutputTags { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to emit latency measure information to the console.
    /// </summary>
    /// <remarks>
    /// Defaults to <see langword="true" />.
    /// </remarks>
    public bool OutputMeasures { get; set; }

    public LarencyConsoleOptions();
}
