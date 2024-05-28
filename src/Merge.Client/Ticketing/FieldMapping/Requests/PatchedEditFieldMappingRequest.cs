using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public class PatchedEditFieldMappingRequest
{
    /// <summary>
    /// The field traversal path of the remote field listed when you hit the GET /remote-fields endpoint.
    /// </summary>
    [JsonPropertyName("remote_field_traversal_path")]
    public List<object>? RemoteFieldTraversalPath { get; init; }

    /// <summary>
    /// The method of the remote endpoint where the remote field is coming from.
    /// </summary>
    [JsonPropertyName("remote_method")]
    public string? RemoteMethod { get; init; }

    /// <summary>
    /// The path of the remote endpoint where the remote field is coming from.
    /// </summary>
    [JsonPropertyName("remote_url_path")]
    public string? RemoteUrlPath { get; init; }
}
