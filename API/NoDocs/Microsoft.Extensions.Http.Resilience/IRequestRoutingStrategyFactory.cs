// Assembly 'Microsoft.Extensions.Http.Resilience'

using System.ComponentModel;

namespace Microsoft.Extensions.Http.Resilience;

[EditorBrowsable(EditorBrowsableState.Never)]
public interface IRequestRoutingStrategyFactory
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    IRequestRoutingStrategy CreateRoutingStrategy();
}
