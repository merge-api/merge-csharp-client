using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public class RemoteKey
{
    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("key")]
    public string Key { get; init; }
}
