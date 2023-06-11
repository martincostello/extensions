// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Time.Testing;
using Xunit;

namespace Microsoft.Extensions.Telemetry.Testing.Metering.Test;

public static class MetricCollectorTests
{
    [Fact]
    public static void Constructor_NullAndEmptyChecks()
    {
        Assert.Throws<ArgumentNullException>(() => new MetricCollector<long>(null!));
        Assert.Throws<ArgumentNullException>(() => new MetricCollector<long>(new Meter("Bar"), null!));
        Assert.Throws<ArgumentNullException>(() => new MetricCollector<long>(null!, "Hello"));
        Assert.Throws<ArgumentNullException>(() => new MetricCollector<long>(null!, null, "Hello"));
        Assert.Throws<ArgumentNullException>(() => new MetricCollector<long>("Hello", null, null!));

        Assert.Throws<ArgumentException>(() => new MetricCollector<long>(new Meter("Foo"), string.Empty));
        Assert.Throws<ArgumentException>(() => new MetricCollector<long>(string.Empty, null, "Hello"));
        Assert.Throws<ArgumentException>(() => new MetricCollector<long>("Hello", null, string.Empty));
    }

    [Fact]
    public static void Constructor_TypeChecks()
    {
        using var meter = new Meter("Meter");
        var counter = meter.CreateCounter<long>("Counter");

        Assert.Throws<InvalidOperationException>(() => new MetricCollector<Guid>(counter));
        Assert.Throws<InvalidOperationException>(() => new MetricCollector<Guid>(meter, "Counter"));
        Assert.Throws<InvalidOperationException>(() => new MetricCollector<Guid>(meter.Name, null, "Counter"));
    }

    [Fact]
    public static void Constructor_Meter_Counter()
    {
        const string MeterName = "MyMeter";
        const string CounterName = "MyCounter";

        var now = DateTimeOffset.Now;

        var timeProvider = new FakeTimeProvider(now);
        using var meter = new Meter(MeterName);
        using var collector = new MetricCollector<long>(meter, CounterName, timeProvider);
        VerifyClean(collector);

        var counter = meter.CreateCounter<long>(CounterName);
        counter.Add(3);

        // verify the update was recorded
        Assert.Equal(counter, collector.Instrument);
        Assert.NotNull(collector.LatestMeasurementTaken);
        Assert.NotNull(collector.LatestMetricValueUpdated);

        // verify measurement info is correct
        Assert.Single(collector.SnapshotMeasurements());
        Assert.Same(collector.SnapshotMeasurements().Last(), collector.LatestMeasurementTaken);
        Assert.Equal(3, collector.LatestMeasurementTaken.Value);
        Assert.Empty(collector.LatestMeasurementTaken.Tags);
        Assert.Equal(now, collector.LatestMeasurementTaken.Timestamp);

        // verify value info is correct
        Assert.Single(collector.SnapshotMetricValues());
        Assert.Equal(3, collector.LatestMetricValueUpdated.Value);
        Assert.Equal(1, collector.LatestMetricValueUpdated.NumWrites);
        Assert.Empty(collector.LatestMetricValueUpdated.Tags);

        counter.Add(2);

        // verify measurement info is correct
        Assert.Equal(2, collector.SnapshotMeasurements().Count);
        Assert.Same(collector.SnapshotMeasurements().Last(), collector.LatestMeasurementTaken);
        Assert.Equal(2, collector.LatestMeasurementTaken.Value);
        Assert.Empty(collector.LatestMeasurementTaken.Tags);
        Assert.Equal(now, collector.LatestMeasurementTaken.Timestamp);

        // verify value info is correct
        Assert.Single(collector.SnapshotMetricValues());
        Assert.Equal(5, collector.LatestMetricValueUpdated.Value);
        Assert.Equal(2, collector.LatestMetricValueUpdated.NumWrites);
        Assert.Empty(collector.LatestMetricValueUpdated.Tags);

        collector.Clear();
        Assert.Empty(collector.SnapshotMeasurements());
        Assert.Empty(collector.SnapshotMetricValues());
        Assert.Null(collector.LatestMeasurementTaken);
        Assert.Null(collector.LatestMetricValueUpdated);
    }

    [Fact]
    public static async Task Wait()
    {
        const string MeterName = "MyMeter";
        const string CounterName = "MyCounter";

        var now = DateTimeOffset.Now;

        var timeProvider = new FakeTimeProvider(now);
        using var meter = new Meter(MeterName);
        using var collector = new MetricCollector<long>(meter, CounterName, timeProvider);
        var counter = meter.CreateCounter<long>(CounterName);

        await Assert.ThrowsAsync<ArgumentOutOfRangeException>(async () => await collector.WaitForMeasurementsAsync(-1));
        await Assert.ThrowsAsync<ArgumentOutOfRangeException>(async () => await collector.WaitForMeasurementsAsync(0));

        var wait = collector.WaitForMeasurementsAsync(2);
        Assert.False(wait.IsCompleted);

        counter.Add(1);
        Assert.False(wait.IsCompleted);

        counter.Add(1);
        Assert.True(wait.IsCompleted);
        Assert.False(wait.IsFaulted);
    }

    [Fact]
    public static async Task WaitWithTimeout()
    {
        const string MeterName = "MyMeter";
        const string CounterName = "MyCounter";

        var now = DateTimeOffset.Now;

        var timeProvider = new FakeTimeProvider(now);
        using var meter = new Meter(MeterName);
        using var collector = new MetricCollector<long>(meter, CounterName, timeProvider);
        var counter = meter.CreateCounter<long>(CounterName);

        await Assert.ThrowsAsync<ArgumentOutOfRangeException>(async () => await collector.WaitForMeasurementsAsync(-1));
        await Assert.ThrowsAsync<ArgumentOutOfRangeException>(async () => await collector.WaitForMeasurementsAsync(0));

        var wait = collector.WaitForMeasurementsAsync(2, TimeSpan.FromSeconds(1));
        Assert.False(wait.IsCompleted);

        counter.Add(1);
        Assert.False(wait.IsCompleted);

        timeProvider.Advance(TimeSpan.FromSeconds(1));
        Assert.True(wait.IsCompleted);
        Assert.True(wait.IsFaulted);
    }

    private static void VerifyClean<T>(MetricCollector<T> collector)
        where T : struct
    {
        Assert.Null(collector.Instrument);
        Assert.Empty(collector.SnapshotMeasurements());
        Assert.Empty(collector.SnapshotMetricValues());
        Assert.Null(collector.LatestMeasurementTaken);
        Assert.Null(collector.LatestMetricValueUpdated);
    }
}
