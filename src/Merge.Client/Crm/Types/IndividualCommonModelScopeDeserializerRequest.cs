using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public record IndividualCommonModelScopeDeserializerRequest
{
    [JsonPropertyName("model_name")]
    public required string ModelName { get; set; }

    [JsonPropertyName("model_permissions")]
    public Dictionary<string, ModelPermissionDeserializerRequest>? ModelPermissions { get; set; }

    [JsonPropertyName("field_permissions")]
    public FieldPermissionDeserializerRequest? FieldPermissions { get; set; }
}
