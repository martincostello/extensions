// Assembly 'Microsoft.Extensions.Resilience'

using System.Threading.Tasks;
using Microsoft.Extensions.Resilience.Options;

namespace Microsoft.Extensions.Resilience;

public delegate Task<TResult> FallbackScenarioTaskProvider<TResult>(FallbackScenarioTaskArguments args);
