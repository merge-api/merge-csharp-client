using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public class FieldPermissionDeserializer
{
    [JsonPropertyName("enabled")]
    public List<object>? Enabled { get; init; }

    [JsonPropertyName("disabled")]
    public List<object>? Disabled { get; init; }
}
