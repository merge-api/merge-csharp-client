using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class ApplicationEndpointRequest
{
    /// <summary>
    /// Whether to include debug fields (such as log file links) in the response.
    /// </summary>
    public bool? IsDebugMode { get; init; }

    /// <summary>
    /// Whether or not third-party updates should be run asynchronously.
    /// </summary>
    public bool? RunAsync { get; init; }

    public ApplicationRequest Model { get; init; }

    public string RemoteUserId { get; init; }
}
