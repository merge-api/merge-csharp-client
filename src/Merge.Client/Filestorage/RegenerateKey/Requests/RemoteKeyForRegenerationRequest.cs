using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Filestorage;

public record RemoteKeyForRegenerationRequest
{
    /// <summary>
    /// The name of the remote key
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
