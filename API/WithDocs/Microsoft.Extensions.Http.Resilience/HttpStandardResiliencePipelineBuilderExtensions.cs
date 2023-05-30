// Assembly 'Microsoft.Extensions.Http.Resilience'

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Compliance.Classification;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.Http.Resilience;

/// <summary>
/// Extensions for <see cref="T:Microsoft.Extensions.Http.Resilience.IHttpStandardResiliencePipelineBuilder" />.
/// </summary>
public static class HttpStandardResiliencePipelineBuilderExtensions
{
    /// <summary>
    /// Configures the <see cref="T:Microsoft.Extensions.Http.Resilience.HttpStandardResilienceOptions" /> for the standard pipeline.
    /// </summary>
    /// <param name="builder">The pipeline builder.</param>
    /// <param name="section">The section that the options will bind against.</param>
    /// <returns>The same builder instance.</returns>
    public static IHttpStandardResiliencePipelineBuilder Configure(this IHttpStandardResiliencePipelineBuilder builder, IConfigurationSection section);

    /// <summary>
    /// Configures the <see cref="T:Microsoft.Extensions.Http.Resilience.HttpStandardResilienceOptions" /> for the standard pipeline.
    /// </summary>
    /// <param name="builder">The pipeline builder.</param>
    /// <param name="configure">The configure method.</param>
    /// <returns>The same builder instance.</returns>
    public static IHttpStandardResiliencePipelineBuilder Configure(this IHttpStandardResiliencePipelineBuilder builder, Action<HttpStandardResilienceOptions> configure);

    /// <summary>
    /// Configures the <see cref="T:Microsoft.Extensions.Http.Resilience.HttpStandardResilienceOptions" /> for the standard pipeline.
    /// </summary>
    /// <param name="builder">The pipeline builder.</param>
    /// <param name="configure">The configure method.</param>
    /// <returns>The same builder instance.</returns>
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static IHttpStandardResiliencePipelineBuilder Configure(this IHttpStandardResiliencePipelineBuilder builder, Action<HttpStandardResilienceOptions, IServiceProvider> configure);

    /// <summary>
    /// Instructs the underlying pipeline builder to select the pipeline instance by redacted authority (scheme + host + port).
    /// </summary>
    /// <param name="builder">The builder instance.</param>
    /// <param name="classification">The data class associated with the authority.</param>
    /// <returns>The same builder instance.</returns>
    /// <remarks>The authority is redacted using <see cref="T:Microsoft.Extensions.Compliance.Redaction.Redactor" /> retrieved for <paramref name="classification" />.</remarks>
    public static IHttpStandardResiliencePipelineBuilder SelectPipelineByAuthority(this IHttpStandardResiliencePipelineBuilder builder, DataClassification classification);

    /// <summary>
    /// Instructs the underlying pipeline builder to select the pipeline instance by custom selector.
    /// </summary>
    /// <param name="builder">The builder instance.</param>
    /// <param name="selectorFactory">The factory that returns <see cref="T:Microsoft.Extensions.Http.Resilience.PipelineKeySelector" /> selector.</param>
    /// <returns>The same builder instance.</returns>
    /// <remarks>The pipeline key is used in metrics and logs, do not return any sensitive value.</remarks>
    public static IHttpStandardResiliencePipelineBuilder SelectPipelineBy(this IHttpStandardResiliencePipelineBuilder builder, Func<IServiceProvider, PipelineKeySelector> selectorFactory);
}
