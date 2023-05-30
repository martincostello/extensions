// Assembly 'System.Cloud.DocumentDb.Abstractions'

using System.Runtime.CompilerServices;

namespace System.Cloud.DocumentDb;

/// <summary>
/// The struct representing read only table configurations.
/// </summary>
/// <remarks>
/// Contains similar information as <see cref="T:System.Cloud.DocumentDb.TableOptions" />,
/// but can not be extended and modified.
/// It is designed to be used in a hot pass,
/// and having 8x performance comparing to using <see cref="T:System.Cloud.DocumentDb.TableOptions" />.
/// </remarks>
public readonly struct TableInfo
{
    /// <summary>
    /// Gets the table name.
    /// </summary>
    /// <remarks>
    /// Default is <see cref="F:System.String.Empty" />.
    /// The value is required.
    /// </remarks>
    public string TableName { get; }

    /// <summary>
    /// Gets the time to live for table items.
    /// </summary>
    /// <remarks>
    /// Default is <see langword="null" />.
    /// If not specified, records will not expire.
    /// 1s is the minimum value.
    /// </remarks>
    public TimeSpan TimeToLive { get; }

    /// <summary>
    /// Gets the partition id path for store.
    /// </summary>
    /// <remarks>
    /// Default is <see langword="null" />.
    /// </remarks>
    public string? PartitionIdPath { get; }

    /// <summary>
    /// Gets a value indicating whether table is regionally replicated or a global.
    /// </summary>
    /// <remarks>
    /// Default is <see langword="false" />, which means table is global.
    /// When enabling regional tables
    /// - All required region endpoints should be configured in client.
    /// - Requests should contain <see cref="P:System.Cloud.DocumentDb.RequestOptions.Region" /> provided.
    /// </remarks>
    public bool IsRegional { get; }

    /// <summary>
    /// Gets the table throughput value.
    /// </summary>
    /// <remarks>
    /// Default is <see cref="F:System.Cloud.DocumentDb.Throughput.Unlimited" />.
    /// <seealso cref="P:System.Cloud.DocumentDb.Throughput.Value" />.
    /// </remarks>
    public Throughput Throughput { get; }

    /// <summary>
    /// Gets a value indicating whether a <see cref="T:System.Cloud.DocumentDb.ITableLocator" /> required to be used with this table.
    /// </summary>
    /// <remarks>
    /// Default is <see langword="false" />, which means locator will not be used even if configured.
    /// If locator is required, requests will require <see cref="T:System.Cloud.DocumentDb.RequestOptions" /> provided to API to provide <see cref="P:System.Cloud.DocumentDb.RequestOptions`1.Document" />.
    /// This is the protection mechanism to avoid engineers not designed specific table to forget provide documents when table locator is in use.
    /// </remarks>
    public bool IsLocatorRequired { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Cloud.DocumentDb.TableInfo" /> struct.
    /// </summary>
    /// <param name="options">The table options.</param>
    public TableInfo(TableOptions options);

    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Cloud.DocumentDb.TableInfo" /> struct.
    /// </summary>
    /// <param name="info">The source table info.</param>
    /// <param name="tableNameOverride">The table name.</param>
    /// <param name="isRegionalOverride">Is the table regional.</param>
    public TableInfo(in TableInfo info, string? tableNameOverride = null, bool? isRegionalOverride = null);
}
