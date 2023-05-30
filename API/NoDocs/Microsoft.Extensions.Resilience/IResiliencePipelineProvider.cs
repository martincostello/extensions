// Assembly 'Microsoft.Extensions.Resilience'

using Polly;

namespace Microsoft.Extensions.Resilience;

public interface IResiliencePipelineProvider
{
    IAsyncPolicy<TResult> GetPipeline<TResult>(string pipelineName);
    IAsyncPolicy<TResult> GetPipeline<TResult>(string pipelineName, string pipelineKey);
}
