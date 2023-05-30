// Assembly 'Microsoft.Extensions.Http.Resilience'

using System.Net.Http;

namespace Microsoft.Extensions.Http.Resilience;

/// <summary>
/// A function that returns a pipeline key extracted from the request message.
/// </summary>
/// <param name="requestMessage">The request message that the pipeline key is extracted from.</param>
/// <returns>A pipeline key.</returns>
/// <remarks>
/// The pipeline key is used by metrics and telemetry. Make sure it does not contain any sensitive data.
/// </remarks>
public delegate string PipelineKeySelector(HttpRequestMessage requestMessage);
