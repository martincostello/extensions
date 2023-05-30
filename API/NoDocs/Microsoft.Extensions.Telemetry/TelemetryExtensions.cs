// Assembly 'Microsoft.Extensions.Telemetry'

using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http.Telemetry;

namespace Microsoft.Extensions.Telemetry;

public static class TelemetryExtensions
{
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static void SetRequestMetadata(this HttpWebRequest request, RequestMetadata metadata);
    public static void SetRequestMetadata(this HttpRequestMessage request, RequestMetadata metadata);
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static RequestMetadata? GetRequestMetadata(this HttpWebRequest request);
    public static RequestMetadata? GetRequestMetadata(this HttpRequestMessage request);
    public static IServiceCollection AddDownstreamDependencyMetadata(this IServiceCollection services, IDownstreamDependencyMetadata downstreamDependencyMetadata);
    public static IServiceCollection AddDownstreamDependencyMetadata<T>(this IServiceCollection services) where T : class, IDownstreamDependencyMetadata;
}
