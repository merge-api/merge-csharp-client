namespace Merge.Client.Accounting;

public class CreateFieldMappingRequest
{
    /// <summary>
    /// The name of the target field you want this remote field to map to.
    /// </summary>
    public string TargetFieldName { get; init; }

    /// <summary>
    /// The description of the target field you want this remote field to map to.
    /// </summary>
    public string TargetFieldDescription { get; init; }

    /// <summary>
    /// The field traversal path of the remote field listed when you hit the GET /remote-fields endpoint.
    /// </summary>
    public List<object> RemoteFieldTraversalPath { get; init; }

    /// <summary>
    /// The method of the remote endpoint where the remote field is coming from.
    /// </summary>
    public string RemoteMethod { get; init; }

    /// <summary>
    /// The path of the remote endpoint where the remote field is coming from.
    /// </summary>
    public string RemoteUrlPath { get; init; }

    /// <summary>
    /// The name of the Common Model that the remote field corresponds to in a given category.
    /// </summary>
    public string CommonModelName { get; init; }
}
