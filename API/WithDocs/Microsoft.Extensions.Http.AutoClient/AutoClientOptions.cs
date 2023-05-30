// Assembly 'Microsoft.Extensions.Http.AutoClient'

using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Microsoft.Extensions.Http.AutoClient;

/// <summary>
/// Options to configure generated REST API clients.
/// </summary>
/// <remarks>
/// This options class is used to configure generated REST API clients.
/// </remarks>
/// <example>
/// <code>
/// services.AddMyDependencyClient(options =&gt;
/// {
///     options.JsonSerializerOptions = new MyJsonSerializerOptions();
/// });
/// </code>
/// </example>
[Experimental]
public class AutoClientOptions
{
    /// <summary>
    /// Gets or sets JSON payload serialization options.
    /// </summary>
    [Required]
    public JsonSerializerOptions JsonSerializerOptions { get; set; }

    public AutoClientOptions();
}
