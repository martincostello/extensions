// Assembly 'Microsoft.AspNetCore.ConnectionTimeout'

using System;
using System.Runtime.CompilerServices;
using Microsoft.Shared.Data.Validation;

namespace Microsoft.AspNetCore.Connections;

/// <summary>
/// Options to configure the connection timeout middleware.
/// </summary>
public class ConnectionTimeoutOptions
{
    /// <summary>
    /// Gets or sets the time after which a connection will be shut down.
    /// </summary>
    /// <remarks>
    /// Default set to 5 minutes.
    /// </remarks>
    [TimeSpan(0, Exclusive = true)]
    public TimeSpan Timeout { get; set; }

    public ConnectionTimeoutOptions();
}
