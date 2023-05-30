// Assembly 'Microsoft.Extensions.Http.Resilience'

using System;
using Microsoft.Extensions.Compliance.Classification;

namespace Microsoft.Extensions.Http.Resilience;

public static class HttpResiliencePipelineBuilderExtensions
{
    public static IHttpResiliencePipelineBuilder SelectPipelineByAuthority(this IHttpResiliencePipelineBuilder builder, DataClassification classification);
    public static IHttpResiliencePipelineBuilder SelectPipelineBy(this IHttpResiliencePipelineBuilder builder, Func<IServiceProvider, PipelineKeySelector> selectorFactory);
}
