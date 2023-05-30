// Assembly 'Microsoft.Extensions.Resilience'

using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Resilience;

[System.Diagnostics.CodeAnalysis.Experimental]
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ResilienceDimensions
{
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string PipelineName = "pipeline_name";
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string PipelineKey = "pipeline_key";
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string ResultType = "result_type";
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string PolicyName = "policy_name";
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string EventName = "event_name";
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string FailureSource = "failure_source";
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string FailureReason = "failure_reason";
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string FailureSummary = "failure_summary";
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string DependencyName = "dep_name";
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string RequestName = "req_name";
    [System.Diagnostics.CodeAnalysis.Experimental]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IReadOnlyList<string> DimensionNames { get; }
}
