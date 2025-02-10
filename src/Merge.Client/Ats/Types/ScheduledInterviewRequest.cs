using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Ats;

public record ScheduledInterviewRequest
{
    /// <summary>
    /// The application being interviewed.
    /// </summary>
    [JsonPropertyName("application")]
    public OneOf<string, Application>? Application { get; set; }

    /// <summary>
    /// The stage of the interview.
    /// </summary>
    [JsonPropertyName("job_interview_stage")]
    public OneOf<string, JobInterviewStage>? JobInterviewStage { get; set; }

    /// <summary>
    /// The user organizing the interview.
    /// </summary>
    [JsonPropertyName("organizer")]
    public OneOf<string, RemoteUser>? Organizer { get; set; }

    /// <summary>
    /// Array of `RemoteUser` IDs.
    /// </summary>
    [JsonPropertyName("interviewers")]
    public IEnumerable<OneOf<string, RemoteUser>>? Interviewers { get; set; }

    /// <summary>
    /// The interview's location.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// When the interview was started.
    /// </summary>
    [JsonPropertyName("start_at")]
    public DateTime? StartAt { get; set; }

    /// <summary>
    /// When the interview was ended.
    /// </summary>
    [JsonPropertyName("end_at")]
    public DateTime? EndAt { get; set; }

    /// <summary>
    /// The interview's status.
    ///
    /// - `SCHEDULED` - SCHEDULED
    /// - `AWAITING_FEEDBACK` - AWAITING_FEEDBACK
    /// - `COMPLETE` - COMPLETE
    /// </summary>
    [JsonPropertyName("status")]
    public ScheduledInterviewStatusEnum? Status { get; set; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
