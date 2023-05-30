// Assembly 'Microsoft.Extensions.Resilience'

using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.Resilience;

public static class ServiceCollectionExtensions
{
    public static IResiliencePipelineBuilder<TPolicyResult> AddResiliencePipeline<TPolicyResult>(this IServiceCollection services, string pipelineName);
}
