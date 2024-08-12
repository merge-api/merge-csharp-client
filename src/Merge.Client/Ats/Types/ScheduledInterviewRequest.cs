using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Ats;

public record ScheduledInterviewRequest
{
    /// <summary>
    /// The application being interviewed.
    /// </summary>
    [JsonPropertyName("application")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Application>>))]
    public OneOf<string, Application>? Application { get; set; }

    /// <summary>
    /// The stage of the interview.
    /// </summary>
    [JsonPropertyName("job_interview_stage")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, JobInterviewStage>>))]
    public OneOf<string, JobInterviewStage>? JobInterviewStage { get; set; }

    /// <summary>
    /// The user organizing the interview.
    /// </summary>
    [JsonPropertyName("organizer")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, RemoteUser>>))]
    public OneOf<string, RemoteUser>? Organizer { get; set; }

    /// <summary>
    /// Array of `RemoteUser` IDs.
    /// </summary>
    [JsonPropertyName("interviewers")]
    [JsonConverter(
        typeof(CollectionItemSerializer<
            OneOf<string, RemoteUser>,
            OneOfSerializer<OneOf<string, RemoteUser>>
        >)
    )]
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
}
