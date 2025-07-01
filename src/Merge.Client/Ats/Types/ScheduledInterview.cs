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
public record ScheduledInterview
{
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; set; }

    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

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
    /// When the third party's interview was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; set; }

    /// <summary>
    /// When the third party's interview was updated.
    /// </summary>
    [JsonPropertyName("remote_updated_at")]
    public DateTime? RemoteUpdatedAt { get; set; }

    /// <summary>
    /// The interview's status.
    ///
    /// * `SCHEDULED` - SCHEDULED
    /// * `AWAITING_FEEDBACK` - AWAITING_FEEDBACK
    /// * `COMPLETE` - COMPLETE
    /// </summary>
    [JsonPropertyName("status")]
    public OneOf<ScheduledInterviewStatusEnum, string>? Status { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

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
