// Assembly 'Microsoft.Extensions.Resilience'

using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.Resilience;

public interface IResiliencePipelineBuilder<TResult>
{
    string PipelineName { get; }
    IServiceCollection Services { get; }
}
