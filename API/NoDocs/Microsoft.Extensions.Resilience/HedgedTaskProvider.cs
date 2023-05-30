// Assembly 'Microsoft.Extensions.Resilience'

using System.Threading.Tasks;

namespace Microsoft.Extensions.Resilience;

public delegate bool HedgedTaskProvider(HedgingTaskProviderArguments args, out Task? result);
