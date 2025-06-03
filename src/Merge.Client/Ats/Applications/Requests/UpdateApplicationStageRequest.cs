using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

public record UpdateApplicationStageRequest
{
    /// <summary>
    /// Whether to include debug fields (such as log file links) in the response.
    /// </summary>
    [JsonIgnore]
    public bool? IsDebugMode { get; set; }

    /// <summary>
    /// Whether or not third-party updates should be run asynchronously.
    /// </summary>
    [JsonIgnore]
    public bool? RunAsync { get; set; }

    /// <summary>
    /// The interview stage to move the application to.
    /// </summary>
    [JsonPropertyName("job_interview_stage")]
    public string? JobInterviewStage { get; set; }

    [JsonPropertyName("remote_user_id")]
    public string? RemoteUserId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
