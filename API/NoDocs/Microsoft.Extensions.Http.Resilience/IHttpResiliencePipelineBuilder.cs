// Assembly 'Microsoft.Extensions.Http.Resilience'

using System.Net.Http;
using Microsoft.Extensions.Resilience;

namespace Microsoft.Extensions.Http.Resilience;

public interface IHttpResiliencePipelineBuilder : IResiliencePipelineBuilder<HttpResponseMessage>
{
}
