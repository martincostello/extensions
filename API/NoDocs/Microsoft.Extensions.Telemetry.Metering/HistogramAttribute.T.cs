// Assembly 'Microsoft.Extensions.Telemetry.Abstractions'

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Telemetry.Metering;

[Experimental]
[AttributeUsage(AttributeTargets.Method)]
public sealed class HistogramAttribute<T> : Attribute where T : struct
{
    public string? Name { get; set; }
    public string[]? Dimensions { get; }
    public Type? Type { get; }
    public HistogramAttribute(params string[] dimensions);
    public HistogramAttribute(Type type);
}
