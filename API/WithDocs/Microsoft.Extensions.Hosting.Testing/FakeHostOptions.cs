// Assembly 'Microsoft.Extensions.Hosting.Testing'

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Hosting.Testing;

/// <summary>
/// Options to configure <see cref="T:Microsoft.Extensions.Hosting.Testing.FakeHost" />.
/// </summary>
public class FakeHostOptions
{
    /// <summary>
    /// Gets or sets time limit for host to start.
    /// </summary>
    /// <remarks>Default is 5 seconds. This limit is used if no cancellation token is used by user.</remarks>
    public TimeSpan StartUpTimeout { get; set; }

    /// <summary>
    /// Gets or sets time limit for host to shut down.
    /// </summary>
    /// <remarks>Default is 10 seconds. This limit is used if no cancellation token is used by user.</remarks>
    public TimeSpan ShutDownTimeout { get; set; }

    /// <summary>
    /// Gets or sets time limit for host to be up.
    /// </summary>
    /// <remarks>
    /// Default is 30 seconds.
    /// Value -1 millisecond means infinite time to live.
    /// TimeToLive is not enforced when debugging.
    /// </remarks>
    public TimeSpan TimeToLive { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether fake logging would be configured automatically.
    /// </summary>
    /// <remarks>Default is <see langword="true" />.</remarks>
    public bool FakeLogging { get; set; }

    /// <inheritdoc cref="T:Microsoft.Extensions.DependencyInjection.ServiceProviderOptions" />
    public bool ValidateScopes { get; set; }

    /// <inheritdoc cref="T:Microsoft.Extensions.DependencyInjection.ServiceProviderOptions" />
    public bool ValidateOnBuild { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether fake redaction would be configured automatically.
    /// </summary>
    /// <remarks>Default is <see langword="true" />.</remarks>
    public bool FakeRedaction { get; set; }

    public FakeHostOptions();
}
