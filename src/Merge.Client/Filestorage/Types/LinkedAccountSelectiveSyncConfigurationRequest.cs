using System.Text.Json.Serialization;
using Merge.Client.Filestorage;

namespace Merge.Client.Filestorage;

public class LinkedAccountSelectiveSyncConfigurationRequest
{
    /// <summary>
    /// The conditions belonging to a selective sync.
    /// </summary>
    [JsonPropertyName("linked_account_conditions")]
    public List<LinkedAccountConditionRequest> LinkedAccountConditions { get; init; }
}
