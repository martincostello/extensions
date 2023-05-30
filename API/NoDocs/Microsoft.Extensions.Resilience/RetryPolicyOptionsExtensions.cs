// Assembly 'Microsoft.Extensions.Resilience'

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Extensions.Resilience.Options;

namespace Microsoft.Extensions.Resilience;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class RetryPolicyOptionsExtensions
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IEnumerable<TimeSpan> GetDelays(this RetryPolicyOptions options);
}
