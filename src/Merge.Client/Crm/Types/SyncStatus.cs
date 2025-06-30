using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Crm;

/// <summary>
/// # The SyncStatus Object
/// ### Description
/// The `SyncStatus` object is used to represent the syncing state of an account
///
/// ### Usage Example
/// View the `SyncStatus` for an account to see how recently its models were synced.
/// </summary>
[Serializable]
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
    public OneOf<LastSyncResultEnum, string>? LastSyncResult { get; set; }

    [JsonPropertyName("last_sync_finished")]
    public DateTime? LastSyncFinished { get; set; }

    [JsonPropertyName("status")]
    public required OneOf<StatusFd5Enum, string> Status { get; set; }

    [JsonPropertyName("is_initial_sync")]
    public required bool IsInitialSync { get; set; }

    [JsonPropertyName("selective_sync_configurations_usage")]
    public SelectiveSyncConfigurationsUsageEnum? SelectiveSyncConfigurationsUsage { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
