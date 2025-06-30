using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Ats;

/// <summary>
/// # The ScheduledInterview Object
/// ### Description
/// The `ScheduledInterview` object is used to represent a scheduled interview for a given candidate’s application to a job. An `Application` can have multiple `ScheduledInterview`s depending on the particular hiring process.
/// ### Usage Example
/// Fetch from the `LIST ScheduledInterviews` endpoint and filter by `interviewers` to show all office locations.
/// </summary>
[Serializable]
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
    /// * `SCHEDULED` - SCHEDULED
    /// * `AWAITING_FEEDBACK` - AWAITING_FEEDBACK
    /// * `COMPLETE` - COMPLETE
    /// </summary>
    [JsonPropertyName("status")]
    public OneOf<ScheduledInterviewStatusEnum, string>? Status { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
