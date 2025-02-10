using Merge.Client.Core;

namespace Merge.Client.Crm;

public record PatchedTaskEndpointRequest
{
    /// <summary>
    /// Whether to include debug fields (such as log file links) in the response.
    /// </summary>
    public bool? IsDebugMode { get; set; }

    /// <summary>
    /// Whether or not third-party updates should be run asynchronously.
    /// </summary>
    public bool? RunAsync { get; set; }

    public required PatchedTaskRequest Model { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
