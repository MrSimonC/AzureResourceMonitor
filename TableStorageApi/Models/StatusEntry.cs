using Azure;
using Azure.Data.Tables;

namespace TableStorageApi.Models;

public class StatusEntry : ITableEntity
{
    public string Program { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Message { get; set; } = string.Empty;

    // Below required by ITableEntity
    public string PartitionKey { get; set; } = string.Empty;
    public string RowKey { get; set; } = Guid.NewGuid().ToString();

    // Below not set by user
    public DateTimeOffset? Timestamp { get; set; }
    public ETag ETag { get; set; }
}