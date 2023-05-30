// Assembly 'System.Cloud.DocumentDb.Abstractions'

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Microsoft.Shared.Data.Validation;

namespace System.Cloud.DocumentDb;

public class DatabaseOptions
{
    [Required]
    public string DatabaseName { get; set; }
    public string? DefaultRegionalDatabaseName { get; set; }
    public string? PrimaryKey { get; set; }
    [Required]
    public Uri? Endpoint { get; set; }
    [TimeSpan("00:10:00", "30.00:00:00")]
    public TimeSpan? IdleTcpConnectionTimeout { get; set; }
    public Throughput Throughput { get; set; }
    public JsonSerializerOptions JsonSerializerOptions { get; set; }
    public IList<string> FailoverRegions { get; set; }
    public IDictionary<string, RegionalDatabaseOptions> RegionalDatabaseOptions { get; set; }
    public DatabaseOptions();
}
