using System.Text.Json.Serialization;

namespace Merge.Client.Ticketing;

public class LinkedAccountConditionRequest
{
    /// <summary>
    /// The ID indicating which condition schema to use for a specific condition.
    /// </summary>
    [JsonPropertyName("condition_schema_id")]
    public string ConditionSchemaId { get; init; }

    /// <summary>
    /// The operator for a specific condition.
    /// </summary>
    [JsonPropertyName("operator")]
    public string Operator { get; init; }

    [JsonPropertyName("value")]
    public object Value { get; init; }
}
