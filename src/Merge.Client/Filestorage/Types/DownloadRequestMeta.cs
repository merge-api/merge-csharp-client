using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Filestorage;

public record DownloadRequestMeta
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("method")]
    public required string Method { get; set; }

    [JsonPropertyName("headers")]
    public Dictionary<string, object?> Headers { get; set; } = new Dictionary<string, object?>();

    [JsonPropertyName("body")]
    public Dictionary<string, object?> Body { get; set; } = new Dictionary<string, object?>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
