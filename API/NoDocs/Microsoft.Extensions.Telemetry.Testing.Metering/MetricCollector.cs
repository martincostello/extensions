// Assembly 'Microsoft.Extensions.Telemetry.Testing'

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

namespace Microsoft.Extensions.Telemetry.Testing.Metering;

[System.Diagnostics.CodeAnalysis.Experimental]
public class MetricCollector : IDisposable
{
    public MetricCollector(IEnumerable<string> meterNames, TimeProvider? timeProvider = null);
    public MetricCollector(TimeProvider? timeProvider = null);
    public MetricCollector(Meter meter, TimeProvider? timeProvider = null);
    public void Clear();
    public MetricValuesHolder<T>? GetCounterValues<T>(string counterName) where T : struct;
    public MetricValuesHolder<T>? GetHistogramValues<T>(string histogramName) where T : struct;
    public MetricValuesHolder<T>? GetUpDownCounterValues<T>(string updownCounterName) where T : struct;
    public MetricValuesHolder<T>? GetObservableGaugeValues<T>(string observableGaugeName) where T : struct;
    public MetricValuesHolder<T>? GetObservableCounterValues<T>(string observableCounterName) where T : struct;
    public MetricValuesHolder<T>? GetObservableUpDownCounterValues<T>(string observableUpDownCounterName) where T : struct;
    public T? GetCounterValue<T>(string counterName, params KeyValuePair<string, object?>[] tags) where T : struct;
    public T? GetHistogramValue<T>(string histogramName, params KeyValuePair<string, object?>[] tags) where T : struct;
    public T? GetUpDownCounterValue<T>(string updownCounterName, params KeyValuePair<string, object?>[] tags) where T : struct;
    public T? GetObservableCounterValue<T>(string observableCounterName, params KeyValuePair<string, object?>[] tags) where T : struct;
    public T? GetObservableGaugeValue<T>(string observableGaugeName, params KeyValuePair<string, object?>[] tags) where T : struct;
    public T? GetObservableUpDownCounterValue<T>(string observableUpDownCounterName, params KeyValuePair<string, object?>[] tags) where T : struct;
    public IReadOnlyDictionary<string, MetricValuesHolder<T>>? GetAllCounters<T>() where T : struct;
    public IReadOnlyDictionary<string, MetricValuesHolder<T>>? GetAllUpDownCounters<T>() where T : struct;
    public IReadOnlyDictionary<string, MetricValuesHolder<T>>? GetAllHistograms<T>() where T : struct;
    public IReadOnlyDictionary<string, MetricValuesHolder<T>>? GetAllObservableCounters<T>() where T : struct;
    public IReadOnlyDictionary<string, MetricValuesHolder<T>>? GetAllObservableUpDownCounters<T>() where T : struct;
    public IReadOnlyDictionary<string, MetricValuesHolder<T>>? GetAllObservableGauges<T>() where T : struct;
    public void CollectObservableInstruments();
    public void Dispose();
    protected virtual void Dispose(bool disposing);
}
