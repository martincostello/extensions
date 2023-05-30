// Assembly 'Microsoft.Extensions.Resilience'

using System.Threading.Tasks;
using Microsoft.Extensions.Resilience.Options;

namespace Microsoft.Extensions.Resilience;

/// <summary>
/// A delegate that executes in the fallback scenarios when the initial execution encounters a failure.
/// </summary>
/// <param name="args">Arguments for the fallback scenario task provider. See <see cref="T:Microsoft.Extensions.Resilience.Options.FallbackScenarioTaskArguments" />.</param>
/// <returns>A task representing asynchronous operation.</returns>
/// <seealso cref="T:Microsoft.Extensions.Resilience.Options.FallbackPolicyOptions" />
/// <seealso cref="T:Polly.Fallback.AsyncFallbackPolicy" />
public delegate Task FallbackScenarioTaskProvider(FallbackScenarioTaskArguments args);
