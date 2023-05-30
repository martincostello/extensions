// Assembly 'Microsoft.Extensions.Telemetry.Testing'

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Telemetry.Testing.Metering.Internal;

namespace Microsoft.Extensions.Telemetry.Testing.Metering;

[System.Diagnostics.CodeAnalysis.Experimental]
public sealed class MetricValuesHolder<T> where T : struct
{
    public string MetricName { get; }
    public IReadOnlyCollection<MetricValue<T>> AllValues { get; }
    public T? LatestWrittenValue { get; }
    public MetricValue<T>? LatestWritten { get; }
    public T? GetValue(params KeyValuePair<string, object?>[] tags);
    public void Clear();
}
