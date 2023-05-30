// Assembly 'System.Cloud.DocumentDb.Abstractions'

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace System.Cloud.DocumentDb;

/// <summary>
/// The class representing region specific configurations for database.
/// </summary>
public class RegionalDatabaseOptions
{
    /// <summary>
    /// Gets or sets the regional database name.
    /// </summary>
    /// <remarks>
    /// Default is <see langword="null" />.
    /// If the value is not specified <see cref="P:System.Cloud.DocumentDb.DatabaseOptions.DefaultRegionalDatabaseName" /> will be used.
    /// </remarks>
    public string? DatabaseName { get; set; }

    /// <summary>
    /// Gets or sets the regional database endpoint.
    /// </summary>
    /// <remarks>
    /// The value is required.
    /// </remarks>
    [Required]
    public Uri? Endpoint { get; set; }

    /// <summary>
    /// Gets or sets the key to the account or resource token.
    /// </summary>
    /// <remarks>
    /// Default is <see langword="null" />.
    /// </remarks>
    public string? PrimaryKey { get; set; }

    /// <summary>
    /// Gets or sets a list of preferred regions used for SDK to define failover order for regional database.
    /// </summary>
    /// <remarks>
    /// Default set to empty <see cref="T:System.Collections.Generic.Dictionary`2" />.
    /// </remarks>
    public IList<string> FailoverRegions { get; set; }

    public RegionalDatabaseOptions();
}
