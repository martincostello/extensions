// Assembly 'Microsoft.Extensions.Http.AutoClient'

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Http.AutoClient;

/// <summary>
/// Defines an API POST method.
/// </summary>
/// <remarks>
/// Marks a method within an interface annotated with <see cref="T:Microsoft.Extensions.Http.AutoClient.AutoClientAttribute" /> as an API POST method.
///
/// The return type of an API method must be a <c>Task&lt;T&gt;</c>.
/// If T is a <see cref="T:System.String" /> and the dependency returns "text/plain" content type, the result will be the raw content of the response. Otherwise, it will be deserialized from JSON.
/// If T is of type <see cref="T:System.Net.Http.HttpResponseMessage" />, the result will be the actual response message without further processing.
///
/// If you provide an extra parameter to the method, you should use it between curly braces in the URL to make it an URL parameter. For example: <c>/api/users/{userId}</c>.
/// </remarks>
/// <example>
/// <code>
/// [AutoClient("MyClient")]
/// interface IMyDependencyClient
/// {
///     [Post("/api/users/{userId}")]
///     Task&lt;User&gt; AddUserAsync(string userId, CancellationToken cancellationToken);
/// }
/// </code>
/// </example>
[Experimental]
[AttributeUsage(AttributeTargets.Method)]
public sealed class PostAttribute : Attribute
{
    /// <summary>
    /// Gets the path of the request.
    /// </summary>
    public string Path { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Microsoft.Extensions.Http.AutoClient.PostAttribute" /> class.
    /// </summary>
    /// <param name="path">The path of the request.</param>
    public PostAttribute(string path);
}
