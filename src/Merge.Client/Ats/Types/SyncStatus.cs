using System.Text.Json.Serialization;
using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class SyncStatus
{
    [JsonPropertyName("model_name")]
    public string ModelName { get; init; }

    [JsonPropertyName("model_id")]
    public string ModelId { get; init; }

    [JsonPropertyName("last_sync_start")]
    public DateTime? LastSyncStart { get; init; }

    [JsonPropertyName("next_sync_start")]
    public DateTime? NextSyncStart { get; init; }

    [JsonPropertyName("status")]
    public SyncStatusStatusEnum Status { get; init; }

    [JsonPropertyName("is_initial_sync")]
    public bool IsInitialSync { get; init; }

    [JsonPropertyName("selective_sync_configurations_usage")]
    public SelectiveSyncConfigurationsUsageEnum? SelectiveSyncConfigurationsUsage { get; init; }
}
