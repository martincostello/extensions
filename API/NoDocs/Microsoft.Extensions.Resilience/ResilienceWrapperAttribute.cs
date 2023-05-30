// Assembly 'Microsoft.Extensions.Resilience'

using System;

namespace Microsoft.Extensions.Resilience;

[AttributeUsage(AttributeTargets.Class)]
public sealed class ResilienceWrapperAttribute : Attribute
{
    public ResilienceWrapperAttribute();
}
