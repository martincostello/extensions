// Assembly 'Microsoft.Extensions.Http.Resilience'

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Extensions.Http.Resilience;

[EditorBrowsable(EditorBrowsableState.Never)]
public interface IRequestRoutingStrategy
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    bool TryGetNextRoute([NotNullWhen(true)] out Uri? nextRoute);
}
