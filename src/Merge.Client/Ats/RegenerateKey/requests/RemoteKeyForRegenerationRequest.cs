using System.Text.Json.Serialization;

namespace Merge.Client.Ats;

public class RemoteKeyForRegenerationRequest
{
    /// <summary>
    /// The name of the remote key
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }
}
