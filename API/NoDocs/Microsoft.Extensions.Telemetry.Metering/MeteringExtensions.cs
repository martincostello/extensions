// Assembly 'Microsoft.Extensions.Telemetry.Abstractions'

using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.Telemetry.Metering;

public static class MeteringExtensions
{
    [Experimental]
    public static IServiceCollection RegisterMetering(this IServiceCollection services);
}
