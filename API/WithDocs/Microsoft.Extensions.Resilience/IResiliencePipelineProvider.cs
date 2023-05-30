// Assembly 'Microsoft.Extensions.Resilience'

using Polly;

namespace Microsoft.Extensions.Resilience;

/// <summary>
/// The resilience pipeline provider creates and caches pipeline instances that are configured using <see cref="T:Microsoft.Extensions.Resilience.IResiliencePipelineBuilder`1" />.
/// </summary>
/// <seealso cref="T:Microsoft.Extensions.Resilience.IResiliencePipelineBuilder`1" />
/// <seealso cref="T:Polly.IAsyncPolicy`1" />
/// <seealso cref="T:Polly.IAsyncPolicy" />
/// <remarks>
/// Use this interface to create instances of both generic and non-generic resilience pipelines.
/// </remarks>
public interface IResiliencePipelineProvider
{
    /// <summary>Gets the pipeline instance.</summary>
    /// <param name="pipelineName">A pipeline name.</param>
    /// <returns>The pipeline instance.</returns>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <exception cref="T:System.ArgumentException">The <paramref name="pipelineName" /> cannot be an empty string.</exception>
    /// <exception cref="T:Microsoft.Extensions.Options.OptionsValidationException">The pipeline identified by <paramref name="pipelineName" /> is invalid or not configured.</exception>
    /// <remarks>
    /// Make sure that the pipeline identified by <paramref name="pipelineName" /> is configured, otherwise the provider won't be able to create
    /// it and throws an error.
    /// </remarks>
    IAsyncPolicy<TResult> GetPipeline<TResult>(string pipelineName);

    /// <summary>Gets a <paramref name="pipelineName" /> pipeline instance cached by <paramref name="pipelineKey" />. If the target pipeline is not cached yet,
    /// the provider creates and caches it and then returns the instance.</summary>
    /// <param name="pipelineName">A pipeline name.</param>
    /// <param name="pipelineKey">The pipeline key associated with a cached instance of a <paramref name="pipelineName" /> pipeline.</param>
    /// <returns>The pipeline instance.</returns>
    /// <typeparam name="TResult">The type of the result returned by the action executed by the policies.</typeparam>
    /// <exception cref="T:System.ArgumentException">The <paramref name="pipelineName" /> cannot be an empty string.</exception>
    /// <exception cref="T:Microsoft.Extensions.Options.OptionsValidationException">The pipeline identified by <paramref name="pipelineName" /> is invalid or not configured.</exception>
    /// <remarks>
    /// This method enables to have multiple instances of the same <paramref name="pipelineName" /> pipeline that are cached by the <paramref name="pipelineKey" />.
    /// Make sure that the pipeline identified by <paramref name="pipelineName" /> is configured, otherwise the provider won't be able to create
    /// it and throws an error.
    /// </remarks>
    IAsyncPolicy<TResult> GetPipeline<TResult>(string pipelineName, string pipelineKey);
}
