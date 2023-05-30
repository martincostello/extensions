// Assembly 'Microsoft.AspNetCore.Telemetry.Middleware'

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Compliance.Classification;
using Microsoft.Extensions.Http.Telemetry;
using Microsoft.Shared.Data.Validation;

namespace Microsoft.AspNetCore.Telemetry;

/// <summary>
/// Top-level model for formatting incoming HTTP requests and their corresponding responses.
/// </summary>
public class LoggingOptions
{
    /// <summary>
    /// Gets or sets a value indicating whether request will be logged additionally before any further processing.
    /// </summary>
    /// <remarks>
    /// When enabled, two entries will be logged for each incoming request. Note, that the first log record won't be enriched.
    /// When disabled, only one entry will be logged for each incoming request (with corresponding response's data).
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
    /// Gets or sets a strategy how request path should be logged.
    /// </summary>
    /// <remarks>
    /// Make sure you add redactors to ensure that sensitive information doesn't find its way into your log records.
    /// Default set to <see cref="F:Microsoft.AspNetCore.Telemetry.IncomingPathLoggingMode.Formatted" />.
    /// This option only applies when the <see cref="P:Microsoft.AspNetCore.Telemetry.LoggingOptions.RequestPathParameterRedactionMode" />
    /// option is not set to <see cref="F:Microsoft.Extensions.Http.Telemetry.HttpRouteParameterRedactionMode.None" />.
    /// </remarks>
    public IncomingPathLoggingMode RequestPathLoggingMode { get; set; }

    /// <summary>
    /// Gets or sets a value indicating how request path parameter should be redacted.
    /// </summary>
    /// <remarks>
    /// Default set to <see cref="F:Microsoft.Extensions.Http.Telemetry.HttpRouteParameterRedactionMode.Strict" />.
    /// </remarks>
    [System.Diagnostics.CodeAnalysis.Experimental]
    public HttpRouteParameterRedactionMode RequestPathParameterRedactionMode { get; set; }

    /// <summary>
    /// Gets or sets a maximum amount of time to wait for the request body to be read.
    /// </summary>
    /// <remarks>
    /// The number should be above 1 millisecond and below 1 minute.
    /// Default set to 1 second.
    /// </remarks>
    [TimeSpan(1, 60000)]
    public TimeSpan RequestBodyReadTimeout { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the maximum number of bytes of the request/response body to be read.
    /// </summary>
    /// <remarks>
    /// The number should ideally be below 85K to not be allocated on the <see href="https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/large-object-heap">large object heap</see>.
    /// Default set to ≈ 32K.
    /// </remarks>
    [Range(1, 1572864)]
    public int BodySizeLimit { get; set; }

    /// <summary>
    /// Gets or sets a map between HTTP path parameters and their data classification.
    /// </summary>
    /// <remarks>
    /// Default set to an empty dictionary.
    /// If a parameter within a controller's action is not annotated with a data classification attribute and
    /// it's not found in this map, it will be redacted as if it was <see cref="P:Microsoft.Extensions.Compliance.Classification.DataClassification.Unknown" />.
    /// If you don't want a parameter to be redacted, mark it as <see cref="P:Microsoft.Extensions.Compliance.Classification.DataClassification.None" />.
    /// </remarks>
    [Required]
    public IDictionary<string, DataClassification> RouteParameterDataClasses { get; set; }

    /// <summary>
    /// Gets or sets a map between request headers to be logged and their data classification.
    /// </summary>
    /// <remarks>
    /// Default set to an empty dictionary.
    /// That means that no request header will be logged by default.
    /// </remarks>
    [Required]
    public IDictionary<string, DataClassification> RequestHeadersDataClasses { get; set; }

    /// <summary>
    /// Gets or sets the set of request body content types which are considered text and thus possible to log.
    /// </summary>
    /// <remarks>
    /// Make sure to not enable body logging in production environment, as it will cause
    /// both performance impact and leakage of sensitive data.
    /// If you need to log body in production, please go through compliance and security.
    /// Default set to an empty <see cref="T:System.Collections.Generic.HashSet`1" />.
    /// That means that request's body will not be logged by default.
    /// </remarks>
    /// <example>
    /// A typical set of known text content-types like json, xml or text would be:
    /// <code>
    /// RequestBodyContentTypesToLog = new HashSet&lt;string&gt;
    /// {
    ///     "application/*+json",
    ///     "application/*+xml",
    ///     "application/json",
    ///     "application/xml",
    ///     "text/*"
    /// };
    /// </code>
    /// </example>
    [Required]
    public ISet<string> RequestBodyContentTypes { get; set; }

    /// <summary>
    /// Gets or sets a map between response headers to be logged and their data classification.
    /// </summary>
    /// <remarks>
    /// Default set to an empty dictionary.
    /// That means that no response header will be logged by default.
    /// </remarks>
    [Required]
    public IDictionary<string, DataClassification> ResponseHeadersDataClasses { get; set; }

    /// <summary>
    /// Gets or sets the set of response body content types which are considered text and thus possible to log.
    /// </summary>
    /// <remarks>
    /// Make sure to not enable body logging in production environment, as it will cause
    /// both performance impact and leakage of sensitive data.
    /// If you need to log body in production, please go through compliance and security.
    /// Default set to an empty <see cref="T:System.Collections.Generic.HashSet`1" />.
    /// That means that response's body will not be logged by default.
    /// </remarks>
    /// <example>
    /// A typical set of known text content-types like json, xml or text would be:
    /// <code>
    /// ResponseBodyContentTypesToLog = new HashSet&lt;string&gt;
    /// {
    ///     "application/*+json",
    ///     "application/*+xml",
    ///     "application/json",
    ///     "application/xml",
    ///     "text/*"
    /// };
    /// </code>
    /// </example>
    [Required]
    public ISet<string> ResponseBodyContentTypes { get; set; }

    /// <summary>
    /// Gets or sets the set of HTTP paths that should be excluded from logging.
    /// </summary>
    /// <remarks>
    /// Any path added to the set will not be logged.
    /// Paths are case insensitive.
    /// Default set to an empty <see cref="T:System.Collections.Generic.HashSet`1" />.
    /// </remarks>
    /// <example>
    /// A typical set of HTTP paths would be:
    /// <code>
    /// ExcludePathStartsWith = new HashSet&lt;string&gt;
    /// {
    ///     "/probe/live",
    ///     "/probe/ready"
    /// };
    /// </code>
    /// </example>
    [System.Diagnostics.CodeAnalysis.Experimental]
    [Required]
    public ISet<string> ExcludePathStartsWith { get; set; }

    public LoggingOptions();
}
