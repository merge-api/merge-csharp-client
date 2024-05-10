using System.Text.Json.Serialization;

namespace Merge.Client.Ticketing;

public class FieldPermissionDeserializer
{
    [JsonPropertyName("enabled")]
    public List<object>? Enabled { get; init; }

    [JsonPropertyName("disabled")]
    public List<object>? Disabled { get; init; }
}
