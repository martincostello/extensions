// Assembly 'Microsoft.Extensions.Resilience'

using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Resilience;

/// <summary>
/// Constants used for enrichment dimensions.
/// </summary>
/// <remarks>
/// Constants are standardized in <see href="https://aka.ms/commonschema">MS Common Schema</see>.
/// </remarks>
[System.Diagnostics.CodeAnalysis.Experimental]
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ResilienceDimensions
{
    /// <summary>
    /// Pipeline name.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string PipelineName = "pipeline_name";

    /// <summary>
    /// Pipeline key.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string PipelineKey = "pipeline_key";

    /// <summary>
    /// Result type.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string ResultType = "result_type";

    /// <summary>
    /// Policy name.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string PolicyName = "policy_name";

    /// <summary>
    /// Event name.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string EventName = "event_name";

    /// <summary>
    /// Failure source.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string FailureSource = "failure_source";

    /// <summary>
    /// Failure reason.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string FailureReason = "failure_reason";

    /// <summary>
    /// Failure summary.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string FailureSummary = "failure_summary";

    /// <summary>
    /// Dependency name.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string DependencyName = "dep_name";

    /// <summary>
    /// Request name.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string RequestName = "req_name";

    /// <summary>
    /// Gets a list of all dimension names.
    /// </summary>
    /// <returns>A read-only <see cref="T:System.Collections.Generic.IReadOnlyList`1" /> of all dimension names.</returns>
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IReadOnlyList<string> DimensionNames { get; }
}
