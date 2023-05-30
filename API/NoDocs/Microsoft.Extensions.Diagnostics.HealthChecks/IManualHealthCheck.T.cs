// Assembly 'Microsoft.Extensions.Diagnostics.HealthChecks.Core'

using System;

namespace Microsoft.Extensions.Diagnostics.HealthChecks;

public interface IManualHealthCheck<T> : IManualHealthCheck, IDisposable
{
}
