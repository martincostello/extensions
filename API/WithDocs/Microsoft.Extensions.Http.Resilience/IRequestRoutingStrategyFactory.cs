// Assembly 'Microsoft.Extensions.Http.Resilience'

using System.ComponentModel;

namespace Microsoft.Extensions.Http.Resilience;

/// <summary>
/// Defines a factory for creation of request routing strategies.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public interface IRequestRoutingStrategyFactory
{
    /// <summary>
    /// Creates a new instance of <seealso cref="T:Microsoft.Extensions.Http.Resilience.IRequestRoutingStrategy" />.
    /// </summary>
    /// <returns>The RequestRoutingStragegy for providing the routes.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    IRequestRoutingStrategy CreateRoutingStrategy();
}
