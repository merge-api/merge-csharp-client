using System.Text.Json.Serialization;
using Merge.Client.Filestorage;

#nullable enable

namespace Merge.Client.Filestorage;

public class PaginatedSyncStatusList
{
    [JsonPropertyName("next")]
    public string? Next { get; init; }

    [JsonPropertyName("previous")]
    public string? Previous { get; init; }

    [JsonPropertyName("results")]
    public IEnumerable<SyncStatus>? Results { get; init; }
}
