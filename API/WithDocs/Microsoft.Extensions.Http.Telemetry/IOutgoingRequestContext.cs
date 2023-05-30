// Assembly 'Microsoft.Extensions.Telemetry.Abstractions'

namespace Microsoft.Extensions.Http.Telemetry;

/// <summary>
/// Interface that holds outgoing request metadata.
/// </summary>
public interface IOutgoingRequestContext
{
    /// <summary>
    /// Gets or sets the metadata for outgoing requests.
    /// </summary>
    RequestMetadata? RequestMetadata { get; set; }
}
