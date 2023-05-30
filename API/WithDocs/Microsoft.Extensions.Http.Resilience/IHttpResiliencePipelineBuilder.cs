// Assembly 'Microsoft.Extensions.Http.Resilience'

using System.Net.Http;
using Microsoft.Extensions.Resilience;

namespace Microsoft.Extensions.Http.Resilience;

/// <summary>
/// The builder for configuring the HTTP client resilience pipeline.
/// </summary>
public interface IHttpResiliencePipelineBuilder : IResiliencePipelineBuilder<HttpResponseMessage>
{
}
