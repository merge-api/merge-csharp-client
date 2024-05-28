using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public class ModelPermissionDeserializerRequest
{
    [JsonPropertyName("is_enabled")]
    public bool? IsEnabled { get; init; }
}
