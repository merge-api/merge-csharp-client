using System.Text.Json.Serialization;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class LinkedAccountSelectiveSyncConfigurationRequest
{
    /// <summary>
    /// The conditions belonging to a selective sync.
    /// </summary>
    [JsonPropertyName("linked_account_conditions")]
    public List<LinkedAccountConditionRequest> LinkedAccountConditions { get; init; }
}
