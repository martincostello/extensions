// Assembly 'Microsoft.Extensions.Http.AutoClient'

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Http.AutoClient;

[Experimental]
public class AutoClientException : Exception
{
    public AutoClientHttpError? HttpError { get; }
    public string Path { get; }
    public int? StatusCode { get; }
    public AutoClientException(string? message, string path, AutoClientHttpError? error = null);
}
