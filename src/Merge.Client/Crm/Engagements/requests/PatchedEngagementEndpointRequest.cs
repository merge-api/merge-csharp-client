using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class PatchedEngagementEndpointRequest
{
    /// <summary>
    /// Whether to include debug fields (such as log file links) in the response.
    /// </summary>
    public bool? IsDebugMode { get; init; }

    /// <summary>
    /// Whether or not third-party updates should be run asynchronously.
    /// </summary>
    public bool? RunAsync { get; init; }

    public PatchedEngagementRequest Model { get; init; }
}
