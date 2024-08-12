using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public record RemoteKey
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }
}
