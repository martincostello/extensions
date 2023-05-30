// Assembly 'Microsoft.Extensions.Http.Resilience'

using System.ComponentModel;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.Http.Resilience;

public interface IStandardHedgingHandlerBuilder
{
    string Name { get; }
    IServiceCollection Services { get; }
    IRoutingStrategyBuilder RoutingStrategyBuilder { get; }
    [EditorBrowsable(EditorBrowsableState.Never)]
    IHttpResiliencePipelineBuilder EndpointResiliencePipelineBuilder { get; }
}
