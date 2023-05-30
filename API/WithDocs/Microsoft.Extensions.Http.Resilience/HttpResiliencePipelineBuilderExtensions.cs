// Assembly 'Microsoft.Extensions.Http.Resilience'

using System;
using Microsoft.Extensions.Compliance.Classification;

namespace Microsoft.Extensions.Http.Resilience;

/// <summary>
/// Extensions for <see cref="T:Microsoft.Extensions.Http.Resilience.IHttpResiliencePipelineBuilder" />.
/// </summary>
public static class HttpResiliencePipelineBuilderExtensions
{
    /// <summary>
    /// Instructs the underlying pipeline builder to select the pipeline instance by redacted authority (scheme + host + port).
    /// </summary>
    /// <param name="builder">The builder instance.</param>
    /// <param name="classification">The data class associated with the authority.</param>
    /// <returns>The same builder instance.</returns>
    /// <remarks>The authority is redacted using <see cref="T:Microsoft.Extensions.Compliance.Redaction.Redactor" /> retrieved for <paramref name="classification" />.</remarks>
    public static IHttpResiliencePipelineBuilder SelectPipelineByAuthority(this IHttpResiliencePipelineBuilder builder, DataClassification classification);

    /// <summary>
    /// Instructs the underlying pipeline builder to select the pipeline instance by custom selector.
    /// </summary>
    /// <param name="builder">The builder instance.</param>
    /// <param name="selectorFactory">The factory that returns <see cref="T:Microsoft.Extensions.Http.Resilience.PipelineKeySelector" /> selector.</param>
    /// <returns>The same builder instance.</returns>
    /// <remarks>The pipeline key is used in metrics and logs, do not return any sensitive value.</remarks>
    public static IHttpResiliencePipelineBuilder SelectPipelineBy(this IHttpResiliencePipelineBuilder builder, Func<IServiceProvider, PipelineKeySelector> selectorFactory);
}
