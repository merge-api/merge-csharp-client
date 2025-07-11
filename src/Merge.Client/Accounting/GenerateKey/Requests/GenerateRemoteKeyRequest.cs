using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[Serializable]
public record GenerateRemoteKeyRequest
{
    /// <summary>
    /// The name of the remote key
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
