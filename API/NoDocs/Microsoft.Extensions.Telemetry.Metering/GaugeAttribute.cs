// Assembly 'Microsoft.Extensions.Telemetry.Abstractions'

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Telemetry.Metering;

[AttributeUsage(AttributeTargets.Method)]
public sealed class GaugeAttribute : Attribute
{
    public string? Name { get; set; }
    public string[]? Dimensions { get; }
    public Type? Type { get; }
    public GaugeAttribute(params string[] dimensions);
    public GaugeAttribute(Type type);
}
