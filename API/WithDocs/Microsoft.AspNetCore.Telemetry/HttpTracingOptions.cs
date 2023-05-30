// Assembly 'Microsoft.AspNetCore.Telemetry'

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Compliance.Classification;
using Microsoft.Extensions.Http.Telemetry;

namespace Microsoft.AspNetCore.Telemetry;

/// <summary>
/// Options class for providing configuration parameters to configure incoming HTTP trace auto collection.
/// </summary>
public class HttpTracingOptions
{
    /// <summary>
    /// Gets or sets a map between HTTP request parameters and their data classification.
    /// </summary>
    /// <remarks>
    /// Default set to empty <see cref="T:System.Collections.Generic.Dictionary`2" />.
    /// If a parameter in requestUrl is not found in this map, it will be redacted as if it was <see cref="P:Microsoft.Extensions.Compliance.Classification.DataClassification.Unknown" />.
    /// If the parameter will not contain sensitive information and shouldn't be redacted, mark it as <see cref="P:Microsoft.Extensions.Compliance.Classification.DataClassification.None" />.
    /// </remarks>
    [Required]
    public IDictionary<string, DataClassification> RouteParameterDataClasses { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to include path with redacted parameters.
    /// </summary>
    /// <remarks>
    /// When false the exported traces will contain the route template.
    /// When true, the request path will be recreated using the redacted parameter and included in the exported traces.
    /// Default value is false.
    /// </remarks>
    public bool IncludePath { get; set; }

    /// <summary>
    /// Gets or sets a value indicating how HTTP path parameter should be redacted.
    /// </summary>
    /// <remarks>
    /// Default set to <see cref="F:Microsoft.Extensions.Http.Telemetry.HttpRouteParameterRedactionMode.Strict" />.
    /// It is applicable when <see cref="P:Microsoft.AspNetCore.Telemetry.HttpTracingOptions.IncludePath" /> option is enabled.
    /// </remarks>
    [System.Diagnostics.CodeAnalysis.Experimental]
    public HttpRouteParameterRedactionMode RequestPathParameterRedactionMode { get; set; }

    /// <summary>
    /// Gets or sets a list of paths to exclude when auto collecting traces.
    /// </summary>
    /// <remarks>
    /// Traces for requests matching the exclusion list will not be exported.
    /// </remarks>
    [Required]
    public ISet<string> ExcludePathStartsWith { get; set; }

    public HttpTracingOptions();
}
