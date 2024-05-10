using System.Text.Json.Serialization;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class ConditionSchema
{
    /// <summary>
    /// The ID of the condition schema. This ID is used when updating selective syncs for a linked account.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; init; }

    /// <summary>
    /// The common model for which a condition schema is defined.
    /// </summary>
    [JsonPropertyName("common_model")]
    public string? CommonModel { get; init; }

    [JsonPropertyName("native_name")]
    public string? NativeName { get; init; }

    [JsonPropertyName("field_name")]
    public string? FieldName { get; init; }

    /// <summary>
    /// Whether this condition can only be applied once. If false, the condition can be AND'd together multiple times.
    /// </summary>
    [JsonPropertyName("is_unique")]
    public bool? IsUnique { get; init; }

    /// <summary>
    /// The type of value(s) that can be set for this condition.
    ///
    /// - `BOOLEAN` - BOOLEAN
    /// - `DATE` - DATE
    /// - `DATE_TIME` - DATE_TIME
    /// - `INTEGER` - INTEGER
    /// - `FLOAT` - FLOAT
    /// - `STRING` - STRING
    /// - `LIST_OF_STRINGS` - LIST_OF_STRINGS
    /// </summary>
    [JsonPropertyName("condition_type")]
    public ConditionTypeEnum ConditionType { get; init; }

    /// <summary>
    /// The schemas for the operators that can be used on a condition.
    /// </summary>
    [JsonPropertyName("operators")]
    public List<OperatorSchema> Operators { get; init; }
}
