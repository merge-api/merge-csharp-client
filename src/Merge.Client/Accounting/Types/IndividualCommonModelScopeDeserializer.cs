using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public record IndividualCommonModelScopeDeserializer
{
    [JsonPropertyName("model_name")]
    public required string ModelName { get; set; }

    [JsonPropertyName("model_permissions")]
    public Dictionary<string, ModelPermissionDeserializer>? ModelPermissions { get; set; }

    [JsonPropertyName("field_permissions")]
    public FieldPermissionDeserializer? FieldPermissions { get; set; }
}
