using System.Text.Json.Serialization;

namespace Merge.Client.Ticketing;

public class FieldMappingApiInstanceRemoteFieldRemoteEndpointInfo
{
    [JsonPropertyName("method")]
    public string? Method { get; init; }

    [JsonPropertyName("url_path")]
    public string? UrlPath { get; init; }

    [JsonPropertyName("field_traversal_path")]
    public List<string>? FieldTraversalPath { get; init; }
}
