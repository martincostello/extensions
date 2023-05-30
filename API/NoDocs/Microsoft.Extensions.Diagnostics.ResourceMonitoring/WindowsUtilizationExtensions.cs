// Assembly 'Microsoft.Extensions.Diagnostics.ResourceMonitoring'

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.Diagnostics.ResourceMonitoring;

public static class WindowsUtilizationExtensions
{
    public static IResourceMonitorBuilder AddWindowsProvider(this IResourceMonitorBuilder builder);
    public static IResourceMonitorBuilder AddWindowsPerfCounterPublisher(this IResourceMonitorBuilder builder);
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static IResourceMonitorBuilder AddWindowsCounters(this IResourceMonitorBuilder builder);
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static IResourceMonitorBuilder AddWindowsCounters(this IResourceMonitorBuilder builder, IConfigurationSection section);
    [System.Diagnostics.CodeAnalysis.Experimental]
    public static IResourceMonitorBuilder AddWindowsCounters(this IResourceMonitorBuilder builder, Action<WindowsCountersOptions> configure);
}
