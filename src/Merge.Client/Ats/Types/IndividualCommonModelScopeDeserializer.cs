using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

public record IndividualCommonModelScopeDeserializer
{
    [JsonPropertyName("model_name")]
    public required string ModelName { get; set; }

    [JsonPropertyName("model_permissions")]
    public Dictionary<string, ModelPermissionDeserializer>? ModelPermissions { get; set; }

    [JsonPropertyName("field_permissions")]
    public FieldPermissionDeserializer? FieldPermissions { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
