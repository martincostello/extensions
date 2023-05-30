// Assembly 'Microsoft.Extensions.Http.Resilience'

using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using Polly;

namespace Microsoft.Extensions.Http.Resilience.FaultInjection;

[System.Diagnostics.CodeAnalysis.Experimental]
public static class PolicyContextExtensions
{
    public static Context WithCallingRequestMessage(this Context context, HttpRequestMessage request);
}
