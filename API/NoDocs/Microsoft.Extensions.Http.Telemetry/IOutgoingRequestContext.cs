// Assembly 'Microsoft.Extensions.Telemetry.Abstractions'

namespace Microsoft.Extensions.Http.Telemetry;

public interface IOutgoingRequestContext
{
    RequestMetadata? RequestMetadata { get; set; }
}
