using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Filestorage;

public record FieldPermissionDeserializer
{
    [JsonPropertyName("enabled_fields")]
    public IEnumerable<object>? EnabledFields { get; set; }

    [JsonPropertyName("disabled_fields")]
    public IEnumerable<object>? DisabledFields { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
