namespace Merge.Client.Crm;

public class PatchedEditFieldMappingRequest
{
    /// <summary>
    /// The field traversal path of the remote field listed when you hit the GET /remote-fields endpoint.
    /// </summary>
    public List<object>? RemoteFieldTraversalPath { get; init; }

    /// <summary>
    /// The method of the remote endpoint where the remote field is coming from.
    /// </summary>
    public string? RemoteMethod { get; init; }

    /// <summary>
    /// The path of the remote endpoint where the remote field is coming from.
    /// </summary>
    public string? RemoteUrlPath { get; init; }
}
