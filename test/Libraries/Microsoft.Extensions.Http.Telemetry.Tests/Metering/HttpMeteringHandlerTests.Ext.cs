// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Http.Telemetry.Metering.Internal;
using Microsoft.Extensions.Http.Telemetry.Metering.Test.Internal;
using Microsoft.Extensions.Telemetry;
using Microsoft.Extensions.Telemetry.Metering;
using Microsoft.Extensions.Telemetry.Testing.Metering;
using Xunit;

namespace Microsoft.Extensions.Http.Telemetry.Metering.Test;

public sealed partial class HttpMeteringHandlerTests : IDisposable
{
    [Fact]
    public async Task SendAsync_expectedFailure_EmptyOutgoingRequestMetricEnricher()
    {
        using var meter = new Meter<HttpMeteringHandler>();
        using var metricCollector = new MetricCollector<long>(meter, Metric.OutgoingRequestMetricName);
        using var client = CreateClientWithHandler(meter);

        using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, _expectedFailureUri);

        using var _ = await client.SendAsync(httpRequestMessage, _cancellationTokenSource.Token);

        var latest = metricCollector.LatestMetricValueUpdated;
        Assert.NotNull(latest);
        Assert.True(latest.ContainsDimensions(
            new(Metric.ReqHost, "www.example-expectedfailure.com"),
            new(Metric.DependencyName, TelemetryConstants.Unknown),
            new(Metric.ReqName, $"GET {TelemetryConstants.Unknown}"),
            new(Metric.RspResultCode, 400),
            new(Metric.RspResultCategory, HttpRequestResultType.ExpectedFailure.ToInvariantString())));
    }

    [Fact]
    public async Task SendAsync_TaskCanceledException()
    {
        using var meter = new Meter<HttpMeteringHandler>();
        using var metricCollector = new MetricCollector<long>(meter, Metric.OutgoingRequestMetricName);
        using var client = CreateClientWithHandler(meter);

        using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, _failure1Uri);

        await Assert.ThrowsAsync<TaskCanceledException>(async () => await client.SendAsync(httpRequestMessage, _cancellationTokenSource.Token));

        var latest = metricCollector.LatestMetricValueUpdated;
        Assert.NotNull(latest);
        Assert.True(latest.ContainsDimensions(
            new(Metric.ReqHost, "www.example-failure1.com"),
            new(Metric.DependencyName, TelemetryConstants.Unknown),
            new(Metric.ReqName, $"POST {TelemetryConstants.Unknown}"),
            new(Metric.RspResultCode, (int)HttpStatusCode.GatewayTimeout),
            new(Metric.RspResultCategory, HttpRequestResultType.Failure.ToInvariantString())));
    }

    [Fact]
    public async Task SendAsync_InvalidOperationException()
    {
        using var meter = new Meter<HttpMeteringHandler>();
        using var metricCollector = new MetricCollector<long>(meter, Metric.OutgoingRequestMetricName);
        using var client = CreateClientWithHandler(meter);

        using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, _failure2Uri);

        await Assert.ThrowsAsync<InvalidOperationException>(async () => await client.SendAsync(httpRequestMessage, _cancellationTokenSource.Token));

        var latest = metricCollector.LatestMetricValueUpdated;
        Assert.NotNull(latest);
        Assert.True(latest.ContainsDimensions(
            new(Metric.ReqHost, "www.example-failure2.com"),
            new(Metric.DependencyName, TelemetryConstants.Unknown),
            new(Metric.ReqName, $"POST {TelemetryConstants.Unknown}"),
            new(Metric.RspResultCode, (int)HttpStatusCode.InternalServerError),
            new(Metric.RspResultCategory, HttpRequestResultType.Failure.ToInvariantString())));
    }

    [Fact]
    public async Task SendAsync_Exception_OutgoingRequestMetricEnricherOnly()
    {
        using var meter = new Meter<HttpMeteringHandler>();
        using var metricCollector = new MetricCollector<long>(meter, Metric.OutgoingRequestMetricName);
        using var client = CreateClientWithHandler(meter,
            new List<IOutgoingRequestMetricEnricher>
            {
                new TestEnricher(1),
            });

        using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, _failureUri);
        httpRequestMessage.SetRequestMetadata(new RequestMetadata
        {
            DependencyName = "failure_service",
            RequestRoute = "/foo/failure",
            RequestName = "TestRequestName"
        });

        await Assert.ThrowsAsync<HttpRequestException>(async () => await client.SendAsync(httpRequestMessage, _cancellationTokenSource.Token));

        var latest = metricCollector.LatestMetricValueUpdated;
        Assert.NotNull(latest);
        Assert.True(latest.ContainsDimensions(
            new(Metric.ReqHost, "www.example-failure.com"),
            new(Metric.DependencyName, "failure_service"),
            new(Metric.ReqName, $"POST TestRequestName"),
            new(Metric.RspResultCode, (int)HttpStatusCode.ServiceUnavailable),
            new(Metric.RspResultCategory, HttpRequestResultType.Failure.ToInvariantString()),
            new("test_property_1", "test_value_1")));
    }

    [Fact]
    public async Task SendAsync_HttpRequestException()
    {
        using var meter = new Meter<HttpMeteringHandler>();
        using var metricCollector = new MetricCollector<long>(meter, Metric.OutgoingRequestMetricName);
        using var client = CreateClientWithHandler(meter);

        using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, _failure3Uri);

        await Assert.ThrowsAsync<HttpRequestException>(async () => await client.SendAsync(httpRequestMessage, _cancellationTokenSource.Token));

        var latest = metricCollector.LatestMetricValueUpdated;
        Assert.NotNull(latest);
        Assert.True(latest.ContainsDimensions(
            new(Metric.ReqHost, "www.example-failure3.com"),
            new(Metric.DependencyName, TelemetryConstants.Unknown),
            new(Metric.ReqName, $"POST {TelemetryConstants.Unknown}"),
#if NET6_0_OR_GREATER
            new(Metric.RspResultCode, (int)HttpStatusCode.BadGateway),
#else
            new(Metric.RspResultCode, (int)HttpStatusCode.ServiceUnavailable),
#endif
            new(Metric.RspResultCategory, HttpRequestResultType.Failure.ToInvariantString())));
    }
#pragma warning restore VSTHRD002 // Avoid problematic synchronous waits
}
