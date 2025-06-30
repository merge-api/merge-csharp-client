using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[Serializable]
public record CreateFieldMappingRequest
{
    /// <summary>
    /// If `true`, remote fields metadata is excluded from each field mapping instance (i.e. `remote_fields.remote_key_name` and `remote_fields.schema` will be null). This will increase the speed of the request since these fields require some calculations.
    /// </summary>
    [JsonIgnore]
    public bool? ExcludeRemoteFieldMetadata { get; set; }

    /// <summary>
    /// The name of the target field you want this remote field to map to.
    /// </summary>
    [JsonPropertyName("target_field_name")]
    public required string TargetFieldName { get; set; }

    /// <summary>
    /// The description of the target field you want this remote field to map to.
    /// </summary>
    [JsonPropertyName("target_field_description")]
    public required string TargetFieldDescription { get; set; }

    /// <summary>
    /// The field traversal path of the remote field listed when you hit the GET /remote-fields endpoint.
    /// </summary>
    [JsonPropertyName("remote_field_traversal_path")]
    public IEnumerable<object> RemoteFieldTraversalPath { get; set; } = new List<object>();

    /// <summary>
    /// The method of the remote endpoint where the remote field is coming from.
    /// </summary>
    [JsonPropertyName("remote_method")]
    public required string RemoteMethod { get; set; }

    /// <summary>
    /// The path of the remote endpoint where the remote field is coming from.
    /// </summary>
    [JsonPropertyName("remote_url_path")]
    public required string RemoteUrlPath { get; set; }

    /// <summary>
    /// The name of the Common Model that the remote field corresponds to in a given category.
    /// </summary>
    [JsonPropertyName("common_model_name")]
    public required string CommonModelName { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
