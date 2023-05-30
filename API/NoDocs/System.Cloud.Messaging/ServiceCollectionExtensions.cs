// Assembly 'System.Cloud.Messaging.Abstractions'

using Microsoft.Extensions.DependencyInjection;

namespace System.Cloud.Messaging;

public static class ServiceCollectionExtensions
{
    public static IAsyncProcessingPipelineBuilder AddAsyncPipeline(this IServiceCollection services, string pipelineName);
}
