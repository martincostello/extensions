// Assembly 'Microsoft.Extensions.Http.Telemetry'

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Compliance.Classification;
using Microsoft.Shared.Data.Validation;

namespace Microsoft.Extensions.Http.Telemetry.Logging;

/// <summary>
/// Options to configure HTTP client requests logging.
/// </summary>
public class LoggingOptions
{
    /// <summary>
    /// Gets or sets a value indicating whether request will be logged additionally before any further processing.
    /// </summary>
    /// <remarks>
    /// When enabled, two entries will be logged for each incoming request - one for request and one for response, if available.
    /// When disabled, only one entry will be logged for each incoming request which includes both request and response data.
    /// Default set to <see langword="false" />.
    /// </remarks>
    public bool LogRequestStart { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether HTTP request and response body will be logged.
    /// </summary>
    /// <remarks>
    /// Please avoid enabling this options in production environment as it might lead to leaking privacy information.
    /// Default set to <see langword="false" />.
    /// </remarks>
    public bool LogBody { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the maximum number of bytes of the request or response body to read.
    /// </summary>
    /// <remarks>
    /// The number should ideally be below 85K to not be allocated on the <see href="https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/large-object-heap">large object heap</see>.
    /// Default set to ≈ 32K.
    /// </remarks>
    [Range(1, 1572864)]
    public int BodySizeLimit { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the maximum amount of time to wait for the request or response body to be read.
    /// </summary>
    /// <remarks>
    /// The number should be above 1 millisecond and below 1 hour.
    /// Default set to 1 second.
    /// </remarks>
    [TimeSpan(1, 3600000)]
    public TimeSpan BodyReadTimeout { get; set; }

    /// <summary>
    /// Gets or sets the list of HTTP request content types which are considered text and thus possible to serialize.
    /// </summary>
    [Required]
    public ISet<string> RequestBodyContentTypes { get; set; }

    /// <summary>
    /// Gets or sets the list of HTTP response content types which are considered text and thus possible to serialize.
    /// </summary>
    [Required]
    public ISet<string> ResponseBodyContentTypes { get; set; }

    /// <summary>
    /// Gets or sets the set of HTTP request headers to log and their respective data classes to use for redaction.
    /// </summary>
    /// <remarks>
    /// If empty, no HTTP request headers will be logged.
    /// If the data class is <see cref="P:Microsoft.Extensions.Compliance.Classification.DataClassification.None" />, no redaction will be done.
    /// Default set to <see cref="T:System.Collections.Generic.HashSet`1" />.
    /// </remarks>
    [Required]
    public IDictionary<string, DataClassification> RequestHeadersDataClasses { get; set; }

    /// <summary>
    /// Gets or sets the set of HTTP response headers to log and their respective data classes to use for redaction.
    /// </summary>
    /// <remarks>
    /// If the data class is <see cref="P:Microsoft.Extensions.Compliance.Classification.DataClassification.None" />, no redaction will be done.
    /// If empty, no HTTP response headers will be logged.
    /// Default set to <see cref="T:System.Collections.Generic.HashSet`1" />.
    /// </remarks>
    [Required]
    public IDictionary<string, DataClassification> ResponseHeadersDataClasses { get; set; }

    /// <summary>
    /// Gets or sets a value indicating how outgoing HTTP request path should be logged.
    /// </summary>
    /// <remarks>
    /// Default set to <see cref="F:Microsoft.Extensions.Http.Telemetry.Logging.OutgoingPathLoggingMode.Formatted" />.
    /// This option is applied only when the <see cref="P:Microsoft.Extensions.Http.Telemetry.Logging.LoggingOptions.RequestPathLoggingMode" /> option is not set to <see cref="F:Microsoft.Extensions.Http.Telemetry.HttpRouteParameterRedactionMode.None" />,
    /// otherwise this setting is ignored and unredacted HTTP request path is logged.
    /// </remarks>
    public OutgoingPathLoggingMode RequestPathLoggingMode { get; set; }

    /// <summary>
    /// Gets or sets a value indicating how outgoing HTTP request path parameters should be redacted.
    /// </summary>
    /// <remarks>
    /// Default set to <see cref="F:Microsoft.Extensions.Http.Telemetry.HttpRouteParameterRedactionMode.Strict" />.
    /// </remarks>
    [System.Diagnostics.CodeAnalysis.Experimental]
    public HttpRouteParameterRedactionMode RequestPathParameterRedactionMode { get; set; }

    /// <summary>
    /// Gets the route parameters to redact with their corresponding data classes to apply appropriate redaction.
    /// </summary>
    [Required]
    public IDictionary<string, DataClassification> RouteParameterDataClasses { get; }

    public LoggingOptions();
}
