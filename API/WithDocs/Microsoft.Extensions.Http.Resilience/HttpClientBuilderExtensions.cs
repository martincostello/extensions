// Assembly 'Microsoft.Extensions.Http.Resilience'

using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http.Resilience.Internal;
using Microsoft.Extensions.Resilience;
using Polly;

namespace Microsoft.Extensions.Http.Resilience;

public static class HttpClientBuilderExtensions
{
    /// <summary>
    /// Adds a fallback handler that wraps the execution of the request with a fallback mechanism,
    /// ensuring that the request is retried against a secondary endpoint.
    /// </summary>
    /// <param name="builder">The HTTP client builder.</param>
    /// <param name="configure">The configure callback.</param>
    /// <returns>
    /// An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.
    /// </returns>
    [System.Diagnostics.CodeAnalysis.Experimental("The current form of this API is experimental. A direct replacement for it will be provided in the follow up versions of the SDK. If you're a new adopter, consider using the Hedging handler. If you are already using the API, stay tuned for the next release's features.")]
    public static IHttpClientBuilder AddFallbackHandler(this IHttpClientBuilder builder, Action<FallbackClientHandlerOptions> configure);

    /// <summary>
    /// Adds a fallback handler that wraps the execution of the request with a fallback mechanism,
    /// ensuring that the request is retried against a secondary endpoint.
    /// </summary>
    /// <param name="builder">The HTTP client builder.</param>
    /// <param name="section">The section that the <see cref="T:Microsoft.Extensions.Http.Resilience.FallbackClientHandlerOptions" /> will bind against.</param>
    /// <returns>
    /// An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.
    /// </returns>
    [System.Diagnostics.CodeAnalysis.Experimental("The current form of this API is experimental. A direct replacement for it will be provided in the follow up versions of the SDK. If you're a new adopter, consider using the Hedging handler. If you are already using the API, stay tuned for the next release's features.")]
    public static IHttpClientBuilder AddFallbackHandler(this IHttpClientBuilder builder, IConfigurationSection section);

    /// <summary>
    /// Adds a fallback handler that wraps the execution of the request with a fallback mechanism,
    /// ensuring that the request is retried against a secondary endpoint.
    /// </summary>
    /// <param name="builder">The HTTP client builder.</param>
    /// <param name="section">The section that the <see cref="T:Microsoft.Extensions.Http.Resilience.FallbackClientHandlerOptions" /> will bind against.</param>
    /// <param name="configure">The configure callback.</param>
    /// <returns>
    /// An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.
    /// </returns>
    [System.Diagnostics.CodeAnalysis.Experimental("The current form of this API is experimental. A direct replacement for it will be provided in the follow up versions of the SDK. If you're a new adopter, consider using the Hedging handler. If you are already using the API, stay tuned for the next release's features.")]
    public static IHttpClientBuilder AddFallbackHandler(this IHttpClientBuilder builder, IConfigurationSection section, Action<FallbackClientHandlerOptions> configure);

    /// <summary>
    /// Adds a <see cref="T:Microsoft.Extensions.Http.PolicyHttpMessageHandler" /> that uses a named inline resilience pipeline configured by returned <see cref="T:Microsoft.Extensions.Http.Resilience.IHttpResiliencePipelineBuilder" />.
    /// </summary>
    /// <param name="builder">The builder instance.</param>
    /// <param name="pipelineIdentifier">The custom identifier for the pipeline, used in the name of the pipeline.</param>
    /// <returns>The HTTP pipeline builder instance.</returns>
    /// <remarks>
    /// The final pipeline name is combination of <see cref="P:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder.Name" /> and <paramref name="pipelineIdentifier" />.
    /// Use pipeline identifier if your HTTP client contains multiple resilience handlers.
    /// </remarks>
    public static IHttpResiliencePipelineBuilder AddResilienceHandler(this IHttpClientBuilder builder, string pipelineIdentifier);

    /// <summary>
    /// Adds a <see cref="T:Microsoft.Extensions.Http.PolicyHttpMessageHandler" /> that uses a standard resilience pipeline with default options to send the requests and handle any transient errors.
    /// The pipeline combines multiple policies that are configured based on HTTP-specific <see cref="T:Microsoft.Extensions.Http.Resilience.HttpStandardResilienceOptions" /> options with recommended defaults.
    /// </summary>
    /// <param name="builder">The builder instance.</param>
    /// <param name="section">The section that the options will bind against.</param>
    /// <returns>The HTTP pipeline builder instance.</returns>
    /// <remarks>
    /// See <see cref="T:Microsoft.Extensions.Http.Resilience.HttpStandardResilienceOptions" /> for more details about the individual policies configured by this method.
    /// </remarks>
    public static IHttpStandardResiliencePipelineBuilder AddStandardResilienceHandler(this IHttpClientBuilder builder, IConfigurationSection section);

    /// <summary>
    /// Adds a <see cref="T:Microsoft.Extensions.Http.PolicyHttpMessageHandler" /> that uses a standard resilience pipeline with default options to send the requests and handle any transient errors.
    /// The pipeline combines multiple policies that are configured based on HTTP-specific <see cref="T:Microsoft.Extensions.Http.Resilience.HttpStandardResilienceOptions" /> options with recommended defaults.
    /// </summary>
    /// <param name="builder">The builder instance.</param>
    /// <param name="configure">The action that configures the resilience options.</param>
    /// <returns>The HTTP pipeline builder instance.</returns>
    /// <remarks>
    /// See <see cref="T:Microsoft.Extensions.Http.Resilience.HttpStandardResilienceOptions" /> for more details about the individual policies configured by this method.
    /// </remarks>
    public static IHttpStandardResiliencePipelineBuilder AddStandardResilienceHandler(this IHttpClientBuilder builder, Action<HttpStandardResilienceOptions> configure);

    /// <summary>
    /// Adds a <see cref="T:Microsoft.Extensions.Http.PolicyHttpMessageHandler" /> that uses a standard resilience pipeline with default <see cref="T:Microsoft.Extensions.Http.Resilience.HttpStandardResilienceOptions" />
    /// to send the requests and handle any transient errors.
    /// The pipeline combines multiple policies that are configured based on HTTP-specific <see cref="T:Microsoft.Extensions.Http.Resilience.HttpStandardResilienceOptions" /> options with recommended defaults.
    /// </summary>
    /// <param name="builder">The builder instance.</param>
    /// <returns>The HTTP pipeline builder instance.</returns>
    /// <remarks>
    /// See <see cref="T:Microsoft.Extensions.Http.Resilience.HttpStandardResilienceOptions" /> for more details about the individual policies configured by this method.
    /// </remarks>
    public static IHttpStandardResiliencePipelineBuilder AddStandardResilienceHandler(this IHttpClientBuilder builder);
}
