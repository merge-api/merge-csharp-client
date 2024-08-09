using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public record PaginatedSyncStatusList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<SyncStatus>? Results { get; set; }
}
