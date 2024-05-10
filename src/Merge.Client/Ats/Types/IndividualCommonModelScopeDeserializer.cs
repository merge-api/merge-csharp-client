using System.Text.Json.Serialization;
using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class IndividualCommonModelScopeDeserializer
{
    [JsonPropertyName("model_name")]
    public string ModelName { get; init; }

    [JsonPropertyName("model_permissions")]
    public Dictionary<string, ModelPermissionDeserializer>? ModelPermissions { get; init; }

    [JsonPropertyName("field_permissions")]
    public FieldPermissionDeserializer? FieldPermissions { get; init; }
}
