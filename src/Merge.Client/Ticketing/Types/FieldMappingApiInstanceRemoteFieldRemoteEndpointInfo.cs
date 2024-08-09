using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public record FieldMappingApiInstanceRemoteFieldRemoteEndpointInfo
{
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    [JsonPropertyName("url_path")]
    public string? UrlPath { get; set; }

    [JsonPropertyName("field_traversal_path")]
    public IEnumerable<string>? FieldTraversalPath { get; set; }
}
