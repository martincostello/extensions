// Assembly 'Microsoft.Extensions.Telemetry.Testing'

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Telemetry.Testing.Metering;

[System.Diagnostics.CodeAnalysis.Experimental]
public sealed class MetricValue<T> where T : struct
{
    public T Value { get; }
    public DateTimeOffset Timestamp { get; }
    public IReadOnlyCollection<KeyValuePair<string, object?>> Tags { get; }
    public object? GetDimension(string dimensionName);
}
