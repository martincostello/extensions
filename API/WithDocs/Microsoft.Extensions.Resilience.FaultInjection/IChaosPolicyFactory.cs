// Assembly 'Microsoft.Extensions.Resilience'

using Polly.Contrib.Simmy.Latency;
using Polly.Contrib.Simmy.Outcomes;

namespace Microsoft.Extensions.Resilience.FaultInjection;

/// <summary>
/// Factory for chaos policy creation.
/// </summary>
public interface IChaosPolicyFactory
{
    /// <summary>
    /// Creates an async latency policy with delegate functions to fetch fault injection
    /// settings from <see cref="T:Polly.Context" />.
    /// </summary>
    /// <typeparam name="TResult">The type of value policies created by this method will inject.</typeparam>
    /// <returns>
    /// A latency policy,
    /// an instance of <see cref="T:Polly.Contrib.Simmy.Latency.AsyncInjectLatencyPolicy`1" />.
    /// </returns>
    AsyncInjectLatencyPolicy<TResult> CreateLatencyPolicy<TResult>();

    /// <summary>
    /// Creates an async exception policy with delegate functions to fetch
    /// fault injection settings from <see cref="T:Polly.Context" />.
    /// </summary>
    /// <returns>
    /// An exception policy,
    /// an instance of <see cref="T:Polly.Contrib.Simmy.Outcomes.AsyncInjectOutcomePolicy" />.
    /// </returns>
    AsyncInjectOutcomePolicy CreateExceptionPolicy();
}
