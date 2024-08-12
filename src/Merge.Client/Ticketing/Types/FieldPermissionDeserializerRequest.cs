using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public record FieldPermissionDeserializerRequest
{
    [JsonPropertyName("enabled")]
    public IEnumerable<object>? Enabled { get; set; }

    [JsonPropertyName("disabled")]
    public IEnumerable<object>? Disabled { get; set; }
}
