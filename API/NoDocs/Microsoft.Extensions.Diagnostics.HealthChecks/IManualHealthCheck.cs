// Assembly 'Microsoft.Extensions.Diagnostics.HealthChecks.Core'

using System;

namespace Microsoft.Extensions.Diagnostics.HealthChecks;

public interface IManualHealthCheck : IDisposable
{
    HealthCheckResult Result { get; set; }
}
