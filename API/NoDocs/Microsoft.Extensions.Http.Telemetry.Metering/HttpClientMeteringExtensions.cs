// Assembly 'Microsoft.Extensions.Http.Telemetry'

using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.Http.Telemetry.Metering;

public static class HttpClientMeteringExtensions
{
    public static IServiceCollection AddDefaultHttpClientMetering(this IServiceCollection services);
    public static IHttpClientBuilder AddHttpClientMetering(this IHttpClientBuilder builder);
    public static IServiceCollection AddOutgoingRequestMetricEnricher<T>(this IServiceCollection services) where T : class, IOutgoingRequestMetricEnricher;
    public static IServiceCollection AddOutgoingRequestMetricEnricher(this IServiceCollection services, IOutgoingRequestMetricEnricher enricher);
}
