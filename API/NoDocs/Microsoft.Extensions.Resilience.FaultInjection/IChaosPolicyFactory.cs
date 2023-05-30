// Assembly 'Microsoft.Extensions.Resilience'

using Polly.Contrib.Simmy.Latency;
using Polly.Contrib.Simmy.Outcomes;

namespace Microsoft.Extensions.Resilience.FaultInjection;

public interface IChaosPolicyFactory
{
    AsyncInjectLatencyPolicy<TResult> CreateLatencyPolicy<TResult>();
    AsyncInjectOutcomePolicy CreateExceptionPolicy();
}
