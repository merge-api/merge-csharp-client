using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public record RemoteKey
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }
}
