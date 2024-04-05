using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

namespace Merge.Client.Ticketing;

public class LinkedAccountSelectiveSyncConfiguration
{
    /// <summary>
    /// The conditions belonging to a selective sync.
    /// </summary>
    [JsonPropertyName("linked_account_conditions")]
    public List<LinkedAccountCondition>? LinkedAccountConditions { get; init; }
}
