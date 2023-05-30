// Assembly 'Microsoft.Extensions.Http.AutoClient'

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Http.AutoClient;

[Experimental]
[AttributeUsage(AttributeTargets.Method)]
public sealed class GetAttribute : Attribute
{
    public string Path { get; }
    public GetAttribute(string path);
}
