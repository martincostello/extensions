// Assembly 'Microsoft.Extensions.Resilience'

using System;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.Resilience;

public static class PollyServiceCollectionExtensions
{
    public static IServiceCollection ConfigureFailureResultContext<TResult>(this IServiceCollection services, Func<TResult, FailureResultContext> configure);
}
