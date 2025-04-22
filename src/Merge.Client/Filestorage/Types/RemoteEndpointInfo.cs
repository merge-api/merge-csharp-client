using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Filestorage;

public record RemoteEndpointInfo
{
    [JsonPropertyName("method")]
    public required string Method { get; set; }

    [JsonPropertyName("url_path")]
    public required string UrlPath { get; set; }

    [JsonPropertyName("field_traversal_path")]
    public IEnumerable<object> FieldTraversalPath { get; set; } = new List<object>();

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
