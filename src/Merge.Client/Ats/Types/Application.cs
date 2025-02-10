using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Ats;

public record Application
{
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
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// The candidate applying.
    /// </summary>
    [JsonPropertyName("candidate")]
    public OneOf<string, Candidate>? Candidate { get; set; }

    /// <summary>
    /// The job being applied for.
    /// </summary>
    [JsonPropertyName("job")]
    public OneOf<string, Job>? Job { get; set; }

    /// <summary>
    /// When the application was submitted.
    /// </summary>
    [JsonPropertyName("applied_at")]
    public DateTime? AppliedAt { get; set; }

    /// <summary>
    /// When the application was rejected.
    /// </summary>
    [JsonPropertyName("rejected_at")]
    public DateTime? RejectedAt { get; set; }

    [JsonPropertyName("offers")]
    public IEnumerable<OneOf<string, Offer>>? Offers { get; set; }

    /// <summary>
    /// The application's source.
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>
    /// The user credited for this application.
    /// </summary>
    [JsonPropertyName("credited_to")]
    public OneOf<string, RemoteUser>? CreditedTo { get; set; }

    [JsonPropertyName("screening_question_answers")]
    public IEnumerable<
        OneOf<string, ScreeningQuestionAnswer>
    >? ScreeningQuestionAnswers { get; set; }

    /// <summary>
    /// The application's current stage.
    /// </summary>
    [JsonPropertyName("current_stage")]
    public OneOf<string, JobInterviewStage>? CurrentStage { get; set; }

    /// <summary>
    /// The application's reason for rejection.
    /// </summary>
    [JsonPropertyName("reject_reason")]
    public OneOf<string, RejectReason>? RejectReason { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
