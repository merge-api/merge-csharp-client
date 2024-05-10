namespace Merge.Client.Ats;

public class UpdateApplicationStageRequest
{
    /// <summary>
    /// Whether to include debug fields (such as log file links) in the response.
    /// </summary>
    public bool? IsDebugMode { get; init; }

    /// <summary>
    /// Whether or not third-party updates should be run asynchronously.
    /// </summary>
    public bool? RunAsync { get; init; }

    /// <summary>
    /// The interview stage to move the application to.
    /// </summary>
    public string? JobInterviewStage { get; init; }

    public string? RemoteUserId { get; init; }
}
