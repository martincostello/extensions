// Assembly 'Microsoft.Extensions.Http.Resilience'

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Compliance.Classification;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.Http.Resilience;

public static class HttpStandardResiliencePipelineBuilderExtensions
{
    public static IHttpStandardResiliencePipelineBuilder Configure(this IHttpStandardResiliencePipelineBuilder builder, IConfigurationSection section);
    public static IHttpStandardResiliencePipelineBuilder Configure(this IHttpStandardResiliencePipelineBuilder builder, Action<HttpStandardResilienceOptions> configure);
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static IHttpStandardResiliencePipelineBuilder Configure(this IHttpStandardResiliencePipelineBuilder builder, Action<HttpStandardResilienceOptions, IServiceProvider> configure);
    public static IHttpStandardResiliencePipelineBuilder SelectPipelineByAuthority(this IHttpStandardResiliencePipelineBuilder builder, DataClassification classification);
    public static IHttpStandardResiliencePipelineBuilder SelectPipelineBy(this IHttpStandardResiliencePipelineBuilder builder, Func<IServiceProvider, PipelineKeySelector> selectorFactory);
}
