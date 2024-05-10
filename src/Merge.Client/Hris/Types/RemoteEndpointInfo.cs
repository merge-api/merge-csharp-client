using System.Text.Json.Serialization;

namespace Merge.Client.Hris;

public class RemoteEndpointInfo
{
    [JsonPropertyName("method")]
    public string Method { get; init; }

    [JsonPropertyName("url_path")]
    public string UrlPath { get; init; }

    [JsonPropertyName("field_traversal_path")]
    public List<object> FieldTraversalPath { get; init; }
}
