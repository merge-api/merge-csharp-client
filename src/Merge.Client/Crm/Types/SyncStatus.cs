using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

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

    [JsonPropertyName("status")]
    public required SyncStatusStatusEnum Status { get; set; }

    [JsonPropertyName("is_initial_sync")]
    public required bool IsInitialSync { get; set; }

    [JsonPropertyName("selective_sync_configurations_usage")]
    public SelectiveSyncConfigurationsUsageEnum? SelectiveSyncConfigurationsUsage { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
