// Assembly 'Microsoft.Extensions.Telemetry'

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.Shared.Data.Validation;

namespace Microsoft.Extensions.Telemetry.Metering;

/// <summary>
/// Configuration options for <see cref="T:Microsoft.Extensions.Telemetry.Metering.EventCountersListener" />.
/// </summary>
public class EventCountersCollectorOptions
{
    /// <summary>
    /// Gets or sets a list of EventSources and CounterNames to listen for.
    /// </summary>
    /// <remarks>
    /// It is a dictionary of EventSource to the set of counters that needs to be collected from the event source.
    /// Please visit <see href="https://docs.microsoft.com/en-us/dotnet/core/diagnostics/available-counters" />
    /// for well known event counters and their availability.
    /// Default set to an empty dictionary.
    /// </remarks>
    [Required]
    [Microsoft.Shared.Data.Validation.Length(1)]
    public IDictionary<string, ISet<string>> Counters { get; set; }

    /// <summary>
    /// Gets or sets a sampling interval for counters.
    /// </summary>
    /// <remarks>
    /// Default set to 1 second.
    /// </remarks>
    [TimeSpan("00:00:01", "00:10:00")]
    public TimeSpan SamplingInterval { get; set; }

    /// <summary>
    /// Gets or sets the interval at which to recycle the <see cref="T:Microsoft.Extensions.Telemetry.Metering.EventCountersListener" />.
    /// </summary>
    /// <remarks>
    /// This is a work-around for this <see href="https://github.com/dotnet/runtime/issues/43985">issue</see>.
    /// Default set to 1 hour.
    /// This only has an effect on .NET 5, it is ignored for .NET 6 and above.
    /// </remarks>
    [TimeSpan("00:10:00", "06:00:00")]
    public TimeSpan EventListenerRecyclingInterval { get; set; }

    public EventCountersCollectorOptions();
}
