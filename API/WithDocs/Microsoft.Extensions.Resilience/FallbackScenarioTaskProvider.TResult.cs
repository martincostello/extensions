// Assembly 'Microsoft.Extensions.Resilience'

using System.Threading.Tasks;
using Microsoft.Extensions.Resilience.Options;

namespace Microsoft.Extensions.Resilience;

/// <summary>
/// A delegate that executes in the fallback scenarios when the initial execution encounters a failure.
/// </summary>
/// <typeparam name="TResult">Type of the result returned.</typeparam>
/// <param name="args">Arguments for the fallback scenario task provider. See <see cref="T:Microsoft.Extensions.Resilience.Options.FallbackScenarioTaskArguments" />.</param>
/// <returns>Result of a fallback task.</returns>
/// <seealso cref="T:Microsoft.Extensions.Resilience.Options.FallbackPolicyOptions`1" />
/// <seealso cref="T:Polly.Fallback.AsyncFallbackPolicy`1" />
public delegate Task<TResult> FallbackScenarioTaskProvider<TResult>(FallbackScenarioTaskArguments args);
