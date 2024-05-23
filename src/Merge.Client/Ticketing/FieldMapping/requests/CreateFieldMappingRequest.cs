using System.Text.Json.Serialization;

namespace Merge.Client.Ticketing;

public class CreateFieldMappingRequest
{
    /// <summary>
    /// The name of the target field you want this remote field to map to.
    /// </summary>
    [JsonPropertyName("target_field_name")]
    public string TargetFieldName { get; init; }

    /// <summary>
    /// The description of the target field you want this remote field to map to.
    /// </summary>
    [JsonPropertyName("target_field_description")]
    public string TargetFieldDescription { get; init; }

    /// <summary>
    /// The field traversal path of the remote field listed when you hit the GET /remote-fields endpoint.
    /// </summary>
    [JsonPropertyName("remote_field_traversal_path")]
    public List<object> RemoteFieldTraversalPath { get; init; }

    /// <summary>
    /// The method of the remote endpoint where the remote field is coming from.
    /// </summary>
    [JsonPropertyName("remote_method")]
    public string RemoteMethod { get; init; }

    /// <summary>
    /// The path of the remote endpoint where the remote field is coming from.
    /// </summary>
    [JsonPropertyName("remote_url_path")]
    public string RemoteUrlPath { get; init; }

    /// <summary>
    /// The name of the Common Model that the remote field corresponds to in a given category.
    /// </summary>
    [JsonPropertyName("common_model_name")]
    public string CommonModelName { get; init; }
}
