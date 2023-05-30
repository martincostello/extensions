// Assembly 'Microsoft.Extensions.Resilience'

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Resilience.FaultInjection;

[System.Diagnostics.CodeAnalysis.Experimental]
public class FaultPolicyWeightAssignmentsOptions
{
    public IDictionary<string, double> WeightAssignments { get; set; }
    public FaultPolicyWeightAssignmentsOptions();
}
