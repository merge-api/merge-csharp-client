using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public class GenerateRemoteKeyRequest
{
    /// <summary>
    /// The name of the remote key
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }
}
