// Assembly 'Microsoft.Extensions.Resilience'

using System.Threading.Tasks;

namespace Microsoft.Extensions.Resilience;

public delegate bool HedgedTaskProvider<TResult>(HedgingTaskProviderArguments args, out Task<TResult>? result);
