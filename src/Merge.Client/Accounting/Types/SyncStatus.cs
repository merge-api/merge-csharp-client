using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

public record SyncStatus
{
    [JsonPropertyName("model_name")]
    public required string ModelName { get; set; }

    [JsonPropertyName("model_id")]
    public required string ModelId { get; set; }

    [JsonPropertyName("last_sync_start")]
    public DateTime? LastSyncStart { get; set; }

    [JsonPropertyName("next_sync_start")]
    public DateTime? NextSyncStart { get; set; }

    [JsonPropertyName("last_sync_result")]
    public LastSyncResultEnum? LastSyncResult { get; set; }

    [JsonPropertyName("last_sync_finished")]
    public DateTime? LastSyncFinished { get; set; }

    [JsonPropertyName("status")]
    public required StatusFd5Enum Status { get; set; }

    [JsonPropertyName("is_initial_sync")]
    public required bool IsInitialSync { get; set; }

    [JsonPropertyName("selective_sync_configurations_usage")]
    public SelectiveSyncConfigurationsUsageEnum? SelectiveSyncConfigurationsUsage { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
