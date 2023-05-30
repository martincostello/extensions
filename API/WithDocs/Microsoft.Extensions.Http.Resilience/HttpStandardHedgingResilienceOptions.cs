// Assembly 'Microsoft.Extensions.Http.Resilience'

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Options.Validation;

namespace Microsoft.Extensions.Http.Resilience;

/// <summary>
/// Options for resilient pipeline of policies for usage in hedging HTTP scenarios. It is using 5 chained layers in this order (from the outermost to the innermost):
/// Total Request Timeout -&gt; Hedging -&gt; Bulkhead (per endpoint) -&gt; Circuit Breaker (per endpoint) -&gt; Attempt Timeout (per endpoint).
/// </summary>
/// /// <remarks>
/// The configuration of each policy is initialized with the default options per type. The request goes through these policies:
///
/// 1. Total request timeout policy applies an overall timeout to the execution, ensuring that the request including hedging attempts does not exceed the configured limit.
/// 2. The hedging policy executes the requests against multiple endpoints in case the dependency is slow or returns a transient error.
/// 3. The bulkhead policy limits the maximum number of concurrent requests being send to the dependency.
/// 4. The circuit breaker blocks the execution if too many direct failures or timeouts are detected.
/// 5. The attempt timeout policy limits each request attempt duration and throws if its exceeded.
///
/// The last three policies are assigned to each individual endpoint. The selection of endpoint can be customized by
/// <see cref="M:Microsoft.Extensions.Http.Resilience.StandardHedgingHandlerBuilderExtensions.SelectPipelineByAuthority(Microsoft.Extensions.Http.Resilience.IStandardHedgingHandlerBuilder,Microsoft.Extensions.Compliance.Classification.DataClassification)" /> or
/// <see cref="M:Microsoft.Extensions.Http.Resilience.StandardHedgingHandlerBuilderExtensions.SelectPipelineBy(Microsoft.Extensions.Http.Resilience.IStandardHedgingHandlerBuilder,System.Func{System.IServiceProvider,Microsoft.Extensions.Http.Resilience.PipelineKeySelector})" /> extensions.
///
/// By default, the endpoint is selected by authority (scheme + host + port).
/// </remarks>
public class HttpStandardHedgingResilienceOptions
{
    /// <summary>
    /// Gets or sets the timeout policy options for the total timeout applied on the request execution.
    /// </summary>
    /// <remarks>
    /// By default it is initialized with a unique instance of <see cref="T:Microsoft.Extensions.Http.Resilience.HttpTimeoutPolicyOptions" />
    /// using default properties values.
    /// </remarks>
    [Required]
    [ValidateObjectMembers]
    public HttpTimeoutPolicyOptions TotalRequestTimeoutOptions { get; set; }

    /// <summary>
    /// Gets or sets the hedging policy options.
    /// </summary>
    /// <remarks>
    /// By default it is initialized with a unique instance of <see cref="T:Microsoft.Extensions.Http.Resilience.HttpHedgingPolicyOptions" /> using default properties values.
    /// </remarks>
    [Required]
    [ValidateObjectMembers]
    public HttpHedgingPolicyOptions HedgingOptions { get; set; }

    /// <summary>
    /// Gets or sets the hedging endpoint options.
    /// </summary>
    /// <remarks>
    /// By default it is initialized with a unique instance of <see cref="T:Microsoft.Extensions.Http.Resilience.HedgingEndpointOptions" /> using default properties values.
    /// </remarks>
    [Required]
    [ValidateObjectMembers]
    public HedgingEndpointOptions EndpointOptions { get; set; }

    public HttpStandardHedgingResilienceOptions();
}
