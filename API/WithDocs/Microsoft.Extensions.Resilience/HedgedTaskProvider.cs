// Assembly 'Microsoft.Extensions.Resilience'

using System.Threading.Tasks;

namespace Microsoft.Extensions.Resilience;

/// <summary>
/// A delegate used by the hedging policy to determine whether the next hedged task can be created.
/// </summary>
/// <param name="args">Arguments for the hedged task provider. See <see cref="T:Microsoft.Extensions.Resilience.HedgingTaskProviderArguments" />.</param>
/// <param name="result">Hedged task created by the provider. <see langword="null" /> if the task was not created.</param>
/// <returns><see langword="true" /> if a hedged task is created, <see langword="false" /> otherwise.</returns>
public delegate bool HedgedTaskProvider(HedgingTaskProviderArguments args, out Task? result);
