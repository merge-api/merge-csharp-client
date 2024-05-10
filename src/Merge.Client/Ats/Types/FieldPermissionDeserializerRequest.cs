using System.Text.Json.Serialization;

namespace Merge.Client.Ats;

public class FieldPermissionDeserializerRequest
{
    [JsonPropertyName("enabled")]
    public List<object>? Enabled { get; init; }

    [JsonPropertyName("disabled")]
    public List<object>? Disabled { get; init; }
}