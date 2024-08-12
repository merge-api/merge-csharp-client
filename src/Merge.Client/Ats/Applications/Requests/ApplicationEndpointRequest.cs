namespace Merge.Client.Ats;

public record ApplicationEndpointRequest
{
    /// <summary>
    /// Whether to include debug fields (such as log file links) in the response.
    /// </summary>
    public bool? IsDebugMode { get; set; }

    /// <summary>
    /// Whether or not third-party updates should be run asynchronously.
    /// </summary>
    public bool? RunAsync { get; set; }

    public required ApplicationRequest Model { get; set; }

    public required string RemoteUserId { get; set; }
}
