// Assembly 'Microsoft.Extensions.Resilience'

namespace Microsoft.Extensions.Resilience.Options;

public enum BackoffType
{
    ExponentialWithJitter = 0,
    Constant = 1,
    Linear = 2
}
