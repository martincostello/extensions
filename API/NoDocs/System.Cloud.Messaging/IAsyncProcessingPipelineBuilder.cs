// Assembly 'System.Cloud.Messaging.Abstractions'

using Microsoft.Extensions.DependencyInjection;

namespace System.Cloud.Messaging;

public interface IAsyncProcessingPipelineBuilder
{
    string PipelineName { get; }
    IServiceCollection Services { get; }
}
