using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

namespace Merge.Client.Ticketing;

public class IndividualCommonModelScopeDeserializerRequest
{
    [JsonPropertyName("model_name")]
    public string ModelName { get; init; }

    [JsonPropertyName("model_permissions")]
    public Dictionary<string, ModelPermissionDeserializerRequest>? ModelPermissions { get; init; }

    [JsonPropertyName("field_permissions")]
    public FieldPermissionDeserializerRequest? FieldPermissions { get; init; }
}