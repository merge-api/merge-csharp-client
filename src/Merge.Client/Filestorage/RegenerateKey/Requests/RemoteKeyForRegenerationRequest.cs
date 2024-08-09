using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public record RemoteKeyForRegenerationRequest
{
    /// <summary>
    /// The name of the remote key
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}
