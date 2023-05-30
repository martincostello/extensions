// Assembly 'Microsoft.Extensions.Http.Resilience'

using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Options.Validation;

namespace Microsoft.Extensions.Http.Resilience;

/// <summary>
/// Class for the fallback options definition.
/// </summary>
[System.Diagnostics.CodeAnalysis.Experimental("The current form of this API is experimental. A direct replacement for it will be provided in the follow up versions of the SDK. If you're a new adopter, consider using the Hedging handler. If you are already using the API, stay tuned for the next release's features.")]
public class FallbackClientHandlerOptions
{
    /// <summary>
    /// Gets or sets the base fallback URI.
    /// </summary>
    [Required]
    public Uri? BaseFallbackUri { get; set; }

    /// <summary>
    /// Gets or sets the fallback policy options.
    /// </summary>
    [ValidateObjectMembers]
    public HttpFallbackPolicyOptions FallbackPolicyOptions { get; set; }

    public FallbackClientHandlerOptions();
}
