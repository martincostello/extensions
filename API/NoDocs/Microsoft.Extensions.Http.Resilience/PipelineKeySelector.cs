// Assembly 'Microsoft.Extensions.Http.Resilience'

using System.Net.Http;

namespace Microsoft.Extensions.Http.Resilience;

public delegate string PipelineKeySelector(HttpRequestMessage requestMessage);
