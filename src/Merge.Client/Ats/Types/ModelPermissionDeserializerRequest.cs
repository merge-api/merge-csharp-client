using System.Text.Json.Serialization;

namespace Merge.Client.Ats;

public class ModelPermissionDeserializerRequest
{
    [JsonPropertyName("is_enabled")]
    public bool? IsEnabled { get; init; }
}
