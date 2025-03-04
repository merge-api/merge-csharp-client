using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

public record RemoteEndpointInfo
{
    [JsonPropertyName("method")]
    public required string Method { get; set; }

    [JsonPropertyName("url_path")]
    public required string UrlPath { get; set; }

    [JsonPropertyName("field_traversal_path")]
    public IEnumerable<object> FieldTraversalPath { get; set; } = new List<object>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
