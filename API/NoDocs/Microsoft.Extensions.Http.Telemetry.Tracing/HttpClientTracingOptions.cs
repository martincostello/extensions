// Assembly 'Microsoft.Extensions.Http.Telemetry'

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Compliance.Classification;

namespace Microsoft.Extensions.Http.Telemetry.Tracing;

public class HttpClientTracingOptions
{
    [System.Diagnostics.CodeAnalysis.Experimental]
    public HttpRouteParameterRedactionMode RequestPathParameterRedactionMode { get; set; }
    [Required]
    public IDictionary<string, DataClassification> RouteParameterDataClasses { get; set; }
    public HttpClientTracingOptions();
}
