using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public class FieldMappingApiInstanceRemoteFieldRemoteEndpointInfo
{
    [JsonPropertyName("method")]
    public string? Method { get; init; }

    [JsonPropertyName("url_path")]
    public string? UrlPath { get; init; }

    [JsonPropertyName("field_traversal_path")]
    public IEnumerable<string>? FieldTraversalPath { get; init; }
}
