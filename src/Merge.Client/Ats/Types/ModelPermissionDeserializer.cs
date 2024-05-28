using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public class ModelPermissionDeserializer
{
    [JsonPropertyName("is_enabled")]
    public bool? IsEnabled { get; init; }
}
