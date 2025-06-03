using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Crm.FieldMapping;

public record PatchedEditFieldMappingRequest
{
    /// <summary>
    /// The field traversal path of the remote field listed when you hit the GET /remote-fields endpoint.
    /// </summary>
    [JsonPropertyName("remote_field_traversal_path")]
    public IEnumerable<object>? RemoteFieldTraversalPath { get; set; }

    /// <summary>
    /// The method of the remote endpoint where the remote field is coming from.
    /// </summary>
    [JsonPropertyName("remote_method")]
    public string? RemoteMethod { get; set; }

    /// <summary>
    /// The path of the remote endpoint where the remote field is coming from.
    /// </summary>
    [JsonPropertyName("remote_url_path")]
    public string? RemoteUrlPath { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
