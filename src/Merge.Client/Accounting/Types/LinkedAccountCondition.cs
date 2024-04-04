using System.Text.Json.Serialization;

namespace Merge.Client.Accounting;

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

    /// <summary>
    /// User-facing _native condition_ name. e.g. "Skip Manager".
    /// </summary>
    [JsonPropertyName("native_name")]
    public string? NativeName { get; init; }

    /// <summary>
    /// The operator for a specific condition.
    /// </summary>
    [JsonPropertyName("operator")]
    public string Operator { get; init; }

    [JsonPropertyName("value")]
    public object? Value { get; init; }

    /// <summary>
    /// The name of the field on the common model that this condition corresponds to, if they conceptually match. e.g. "location_type".
    /// </summary>
    [JsonPropertyName("field_name")]
    public string? FieldName { get; init; }
}
