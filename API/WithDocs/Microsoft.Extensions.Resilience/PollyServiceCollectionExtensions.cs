// Assembly 'Microsoft.Extensions.Resilience'

using System;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.Resilience;

/// <summary>
/// Extension class for the Service Collection DI container.
/// </summary>
public static class PollyServiceCollectionExtensions
{
    /// <summary>
    /// Configures the failure result dimensions.
    /// </summary>
    /// <typeparam name="TResult">The type of the policy result.</typeparam>
    /// <param name="services">The services.</param>
    /// <param name="configure">The configure result dimensions.</param>
    /// <returns>The input <paramref name="services" />.</returns>
    public static IServiceCollection ConfigureFailureResultContext<TResult>(this IServiceCollection services, Func<TResult, FailureResultContext> configure);
}
