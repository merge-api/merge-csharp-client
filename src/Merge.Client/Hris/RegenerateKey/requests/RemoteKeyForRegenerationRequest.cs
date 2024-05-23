using System.Text.Json.Serialization;

namespace Merge.Client.Hris;

public class RemoteKeyForRegenerationRequest
{
    /// <summary>
    /// The name of the remote key
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }
}
