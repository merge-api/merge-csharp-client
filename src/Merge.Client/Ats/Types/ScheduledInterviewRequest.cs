using System.Text.Json.Serialization;
using OneOf;
using Merge.Client.Ats;
using StringEnum;

namespace Merge.Client.Ats;

public class ScheduledInterviewRequest
{
    /// <summary>
    /// The application being interviewed.
    /// </summary>
    [JsonPropertyName("application")]
    public OneOf<string, Application>? Application { get; init; }

    /// <summary>
    /// The stage of the interview.
    /// </summary>
    [JsonPropertyName("job_interview_stage")]
    public OneOf<string, JobInterviewStage>? JobInterviewStage { get; init; }

    /// <summary>
    /// The user organizing the interview.
    /// </summary>
    [JsonPropertyName("organizer")]
    public OneOf<string, RemoteUser>? Organizer { get; init; }

    /// <summary>
    /// Array of `RemoteUser` IDs.
    /// </summary>
    [JsonPropertyName("interviewers")]
    public List<OneOf<string, RemoteUser>?>? Interviewers { get; init; }

    /// <summary>
    /// The interview's location.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; init; }

    /// <summary>
    /// When the interview was started.
    /// </summary>
    [JsonPropertyName("start_at")]
    public DateTime? StartAt { get; init; }

    /// <summary>
    /// When the interview was ended.
    /// </summary>
    [JsonPropertyName("end_at")]
    public DateTime? EndAt { get; init; }

    /// <summary>
    /// The interview's status.
    /// 
    /// - `SCHEDULED` - SCHEDULED
    /// - `AWAITING_FEEDBACK` - AWAITING_FEEDBACK
    /// - `COMPLETE` - COMPLETE
    /// </summary>
    [JsonPropertyName("status")]
    public StringEnum<ScheduledInterviewStatusEnum>? Status { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }
}
