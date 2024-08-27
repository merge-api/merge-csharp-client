using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

public record ModelPermissionDeserializerRequest
{
    [JsonPropertyName("is_enabled")]
    public bool? IsEnabled { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
