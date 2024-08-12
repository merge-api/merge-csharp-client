using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public record FieldPermissionDeserializer
{
    [JsonPropertyName("enabled")]
    public IEnumerable<object>? Enabled { get; set; }

    [JsonPropertyName("disabled")]
    public IEnumerable<object>? Disabled { get; set; }
}
