// Assembly 'Microsoft.Extensions.Resilience'

using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.Resilience;

/// <summary>
/// Extension class for the Service Collection DI container.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Returns a generic <see cref="T:Microsoft.Extensions.Resilience.IResiliencePipelineBuilder`1" /> that is used to configure the new resilience pipeline.
    /// </summary>
    /// <typeparam name="TPolicyResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <param name="services">The DI container.</param>
    /// <param name="pipelineName">The pipeline name.</param>
    /// <returns>The input <paramref name="services" />.</returns>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="services" /> cannot be null.</exception>
    public static IResiliencePipelineBuilder<TPolicyResult> AddResiliencePipeline<TPolicyResult>(this IServiceCollection services, string pipelineName);
}
