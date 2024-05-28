using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public class RemoteKeyForRegenerationRequest
{
    /// <summary>
    /// The name of the remote key
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }
}
