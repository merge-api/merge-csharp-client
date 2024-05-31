using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public class FieldPermissionDeserializerRequest
{
    [JsonPropertyName("enabled")]
    public IEnumerable<object>? Enabled { get; init; }

    [JsonPropertyName("disabled")]
    public IEnumerable<object>? Disabled { get; init; }
}
