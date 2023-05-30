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
    [System.Diagnostics.CodeAnalysis.Experimental("The current form of this API is experimental. A direct replacement for it will be provided in the follow up versions of the SDK. If you're a new adopter, consider using the Hedging handler. If you are already using the API, stay tuned for the next release's features.")]
    public static IHttpClientBuilder AddFallbackHandler(this IHttpClientBuilder builder, Action<FallbackClientHandlerOptions> configure);
    [System.Diagnostics.CodeAnalysis.Experimental("The current form of this API is experimental. A direct replacement for it will be provided in the follow up versions of the SDK. If you're a new adopter, consider using the Hedging handler. If you are already using the API, stay tuned for the next release's features.")]
    public static IHttpClientBuilder AddFallbackHandler(this IHttpClientBuilder builder, IConfigurationSection section);
    [System.Diagnostics.CodeAnalysis.Experimental("The current form of this API is experimental. A direct replacement for it will be provided in the follow up versions of the SDK. If you're a new adopter, consider using the Hedging handler. If you are already using the API, stay tuned for the next release's features.")]
    public static IHttpClientBuilder AddFallbackHandler(this IHttpClientBuilder builder, IConfigurationSection section, Action<FallbackClientHandlerOptions> configure);
    public static IHttpResiliencePipelineBuilder AddResilienceHandler(this IHttpClientBuilder builder, string pipelineIdentifier);
    public static IHttpStandardResiliencePipelineBuilder AddStandardResilienceHandler(this IHttpClientBuilder builder, IConfigurationSection section);
    public static IHttpStandardResiliencePipelineBuilder AddStandardResilienceHandler(this IHttpClientBuilder builder, Action<HttpStandardResilienceOptions> configure);
    public static IHttpStandardResiliencePipelineBuilder AddStandardResilienceHandler(this IHttpClientBuilder builder);
}
