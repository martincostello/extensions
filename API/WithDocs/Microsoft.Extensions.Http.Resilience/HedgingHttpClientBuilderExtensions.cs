// Assembly 'Microsoft.Extensions.Http.Resilience'

using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Resilience;

namespace Microsoft.Extensions.Http.Resilience;

/// <summary>
/// Extension methods for configuring <see cref="T:System.Net.Http.DelegatingHandler" /> message handlers as part of
/// the <see cref="T:System.Net.Http.HttpClient" /> message handler pipeline.
/// </summary>
public static class HedgingHttpClientBuilderExtensions
{
    /// <summary>
    /// Adds a standard hedging handler which wraps the execution of the request with a standard hedging mechanism.
    /// </summary>
    /// <param name="builder">The HTTP client builder.</param>
    /// <param name="configure">Configures the routing strategy associated with this handler.</param>
    /// <returns>
    /// A <see cref="T:Microsoft.Extensions.Http.Resilience.IStandardHedgingHandlerBuilder" /> builder that can be used to configure the standard hedging behavior.
    /// </returns>
    /// <remarks>
    /// The standard hedging uses a pipeline pool of circuit breakers to ensure that unhealthy endpoints are not hedged against.
    /// By default, the selection from pool is based on the URL Authority (scheme + host + port).
    ///
    /// It is recommended that you configure the way the pipelines are selected by calling 'SelectPipelineByAuthority' extensions on top of returned <see cref="T:Microsoft.Extensions.Http.Resilience.IStandardHedgingHandlerBuilder" />.
    ///
    /// See <see cref="T:Microsoft.Extensions.Http.Resilience.HttpStandardHedgingResilienceOptions" /> for more details about the policies inside the pipeline.
    /// </remarks>
    public static IStandardHedgingHandlerBuilder AddStandardHedgingHandler(this IHttpClientBuilder builder, Action<IRoutingStrategyBuilder> configure);

    /// <summary>
    /// Adds a standard hedging handler which wraps the execution of the request with a standard hedging mechanism.
    /// </summary>
    /// <param name="builder">The HTTP client builder.</param>
    /// <returns>
    /// A <see cref="T:Microsoft.Extensions.Http.Resilience.IStandardHedgingHandlerBuilder" /> builder that can be used to configure the standard hedging behavior.
    /// </returns>
    /// <remarks>
    /// The standard hedging uses a pipeline pool of circuit breakers to ensure that unhealthy endpoints are not hedged against.
    /// By default, the selection from pool is based on the URL Authority (scheme + host + port).
    ///
    /// It is recommended that you configure the way the pipelines are selected by calling 'SelectPipelineByAuthority' extensions on top of returned <see cref="T:Microsoft.Extensions.Http.Resilience.IStandardHedgingHandlerBuilder" />.
    ///
    /// See <see cref="T:Microsoft.Extensions.Http.Resilience.HttpStandardHedgingResilienceOptions" /> for more details about the policies inside the pipeline.
    /// </remarks>
    public static IStandardHedgingHandlerBuilder AddStandardHedgingHandler(this IHttpClientBuilder builder);
}
