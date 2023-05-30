// Assembly 'Microsoft.Extensions.Http.AutoClient'

using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Microsoft.Extensions.Http.AutoClient;

[Experimental]
public class AutoClientOptions
{
    [Required]
    public JsonSerializerOptions JsonSerializerOptions { get; set; }
    public AutoClientOptions();
}
