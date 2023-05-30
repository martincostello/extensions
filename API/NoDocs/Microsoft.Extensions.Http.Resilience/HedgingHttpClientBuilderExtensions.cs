// Assembly 'Microsoft.Extensions.Http.Resilience'

using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Resilience;

namespace Microsoft.Extensions.Http.Resilience;

public static class HedgingHttpClientBuilderExtensions
{
    public static IStandardHedgingHandlerBuilder AddStandardHedgingHandler(this IHttpClientBuilder builder, Action<IRoutingStrategyBuilder> configure);
    public static IStandardHedgingHandlerBuilder AddStandardHedgingHandler(this IHttpClientBuilder builder);
}
