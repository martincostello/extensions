// Assembly 'Microsoft.Extensions.AsyncState'

using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Extensions.AsyncState;

[Experimental]
[EditorBrowsable(EditorBrowsableState.Never)]
public interface IAsyncLocalContext<T> : IAsyncContext<T> where T : class
{
}
