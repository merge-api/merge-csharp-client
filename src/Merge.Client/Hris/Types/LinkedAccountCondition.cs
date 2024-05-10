using System.Text.Json.Serialization;

namespace Merge.Client.Hris;

public class LinkedAccountCondition
{
    /// <summary>
    /// The ID indicating which condition schema to use for a specific condition.
    /// </summary>
    [JsonPropertyName("condition_schema_id")]
    public string ConditionSchemaId { get; init; }

    /// <summary>
    /// The common model for a specific condition.
    /// </summary>
    [JsonPropertyName("common_model")]
    public string? CommonModel { get; init; }

    [JsonPropertyName("native_name")]
    public string? NativeName { get; init; }

    /// <summary>
    /// The operator for a specific condition.
    /// </summary>
    [JsonPropertyName("operator")]
    public string Operator { get; init; }

    [JsonPropertyName("value")]
    public object? Value { get; init; }

    [JsonPropertyName("field_name")]
    public string? FieldName { get; init; }
}
