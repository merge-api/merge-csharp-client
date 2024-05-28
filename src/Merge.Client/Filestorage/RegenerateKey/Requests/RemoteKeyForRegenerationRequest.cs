using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public class RemoteKeyForRegenerationRequest
{
    /// <summary>
    /// The name of the remote key
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }
}
