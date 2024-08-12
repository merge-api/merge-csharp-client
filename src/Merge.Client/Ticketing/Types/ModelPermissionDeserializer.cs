using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public record ModelPermissionDeserializer
{
    [JsonPropertyName("is_enabled")]
    public bool? IsEnabled { get; set; }
}
