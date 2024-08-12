namespace Merge.Client.Ats;

public record UpdateApplicationStageRequest
{
    /// <summary>
    /// Whether to include debug fields (such as log file links) in the response.
    /// </summary>
    public bool? IsDebugMode { get; set; }

    /// <summary>
    /// Whether or not third-party updates should be run asynchronously.
    /// </summary>
    public bool? RunAsync { get; set; }

    /// <summary>
    /// The interview stage to move the application to.
    /// </summary>
    public string? JobInterviewStage { get; set; }

    public string? RemoteUserId { get; set; }
}
