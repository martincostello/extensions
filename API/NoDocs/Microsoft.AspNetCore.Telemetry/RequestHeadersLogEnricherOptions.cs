// Assembly 'Microsoft.AspNetCore.Telemetry'

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Compliance.Classification;

namespace Microsoft.AspNetCore.Telemetry;

public class RequestHeadersLogEnricherOptions
{
    [Required]
    [System.Diagnostics.CodeAnalysis.Experimental]
    public IDictionary<string, DataClassification> HeadersDataClasses { get; set; }
    public RequestHeadersLogEnricherOptions();
}
