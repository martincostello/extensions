// Assembly 'Microsoft.Extensions.Http.AutoClient'

using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Extensions.Http.AutoClient;

/// <summary>
/// Defines the types of encoding possible for request bodies.
/// </summary>
[Experimental]
public enum BodyContentType
{
    /// <summary>
    /// Represents the "application/json" content type.
    /// </summary>
    /// <remarks>
    /// With this content type, the parameter value is serialized to JSON before sending it in the request.
    /// </remarks>
    ApplicationJson = 0,
    /// <summary>
    /// Represents the "text/plain" content type.
    /// </summary>
    /// <remarks>
    /// With this content type, <c>TString</c> is called on the parameter value before sending it in the request.
    /// </remarks>
    TextPlain = 1
}
