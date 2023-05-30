// Assembly 'Microsoft.Extensions.Http.Resilience'

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Microsoft.Extensions.Http.Resilience;

public static class RoutingStrategyBuilderExtensions
{
    public static IRoutingStrategyBuilder ConfigureOrderedGroups(this IRoutingStrategyBuilder builder, IConfigurationSection section);
    public static IRoutingStrategyBuilder ConfigureOrderedGroups(this IRoutingStrategyBuilder builder, Action<OrderedGroupsRoutingOptions> configure);
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static IRoutingStrategyBuilder ConfigureOrderedGroups(this IRoutingStrategyBuilder builder, Action<OrderedGroupsRoutingOptions, IServiceProvider> configure);
    public static IRoutingStrategyBuilder ConfigureWeightedGroups(this IRoutingStrategyBuilder builder, IConfigurationSection section);
    public static IRoutingStrategyBuilder ConfigureWeightedGroups(this IRoutingStrategyBuilder builder, Action<WeightedGroupsRoutingOptions> configure);
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static IRoutingStrategyBuilder ConfigureWeightedGroups(this IRoutingStrategyBuilder builder, Action<WeightedGroupsRoutingOptions, IServiceProvider> configure);
}
