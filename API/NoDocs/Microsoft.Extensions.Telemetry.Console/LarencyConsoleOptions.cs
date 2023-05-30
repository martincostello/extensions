// Assembly 'Microsoft.Extensions.Telemetry.Console'

using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Telemetry.Console;

public class LarencyConsoleOptions
{
    public bool OutputCheckpoints { get; set; }
    public bool OutputTags { get; set; }
    public bool OutputMeasures { get; set; }
    public LarencyConsoleOptions();
}
