// Assembly 'Microsoft.Extensions.Resilience'

using System;

namespace Microsoft.Extensions.Resilience;

/// <summary>
/// This attribute is used by the source generator
/// in order to generate code for a resilient cache.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public sealed class ResilienceWrapperAttribute : Attribute
{
    public ResilienceWrapperAttribute();
}
