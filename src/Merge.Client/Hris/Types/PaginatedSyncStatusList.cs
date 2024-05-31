using System.Text.Json.Serialization;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

public class PaginatedSyncStatusList
{
    [JsonPropertyName("next")]
    public string? Next { get; init; }

    [JsonPropertyName("previous")]
    public string? Previous { get; init; }

    [JsonPropertyName("results")]
    public IEnumerable<SyncStatus>? Results { get; init; }
}
