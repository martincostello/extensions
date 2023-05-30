// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Extensions.Resilience.Options;

namespace Microsoft.Extensions.Resilience;

/// <summary>
/// Extensions for <see cref="T:Microsoft.Extensions.Resilience.Options.RetryPolicyOptions" />.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class RetryPolicyOptionsExtensions
{
    /// <summary>
    /// Gets the delays generated based on the retry options configuration.
    /// </summary>
    /// <param name="options">The options instance.</param>
    /// <returns>The delays collection.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IEnumerable<TimeSpan> GetDelays(this RetryPolicyOptions options);
}
