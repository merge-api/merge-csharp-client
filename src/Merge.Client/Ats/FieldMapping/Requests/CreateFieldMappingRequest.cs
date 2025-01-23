using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

public record CreateFieldMappingRequest
{
    /// <summary>
    /// If `true`, remote fields metadata is excluded from each field mapping instance (i.e. `remote_fields.remote_key_name` and `remote_fields.schema` will be null). This will increase the speed of the request since these fields require some calculations.
    /// </summary>
    public bool? ExcludeRemoteFieldMetadata { get; set; }

    /// <summary>
    /// The name of the target field you want this remote field to map to.
    /// </summary>
    public required string TargetFieldName { get; set; }

    /// <summary>
    /// The description of the target field you want this remote field to map to.
    /// </summary>
    public required string TargetFieldDescription { get; set; }

    /// <summary>
    /// The field traversal path of the remote field listed when you hit the GET /remote-fields endpoint.
    /// </summary>
    public IEnumerable<object> RemoteFieldTraversalPath { get; set; } = new List<object>();

    /// <summary>
    /// The method of the remote endpoint where the remote field is coming from.
    /// </summary>
    public required string RemoteMethod { get; set; }

    /// <summary>
    /// The path of the remote endpoint where the remote field is coming from.
    /// </summary>
    public required string RemoteUrlPath { get; set; }

    /// <summary>
    /// The name of the Common Model that the remote field corresponds to in a given category.
    /// </summary>
    public required string CommonModelName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
