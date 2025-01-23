using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

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
