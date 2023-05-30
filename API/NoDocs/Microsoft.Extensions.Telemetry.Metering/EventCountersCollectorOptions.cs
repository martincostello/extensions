// Assembly 'Microsoft.Extensions.Telemetry'

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.Shared.Data.Validation;

namespace Microsoft.Extensions.Telemetry.Metering;

public class EventCountersCollectorOptions
{
    [Required]
    [Microsoft.Shared.Data.Validation.Length(1)]
    public IDictionary<string, ISet<string>> Counters { get; set; }
    [TimeSpan("00:00:01", "00:10:00")]
    public TimeSpan SamplingInterval { get; set; }
    [TimeSpan("00:10:00", "06:00:00")]
    public TimeSpan EventListenerRecyclingInterval { get; set; }
    public EventCountersCollectorOptions();
}
