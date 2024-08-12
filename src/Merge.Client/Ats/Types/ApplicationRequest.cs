using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Ats;

public record ApplicationRequest
{
    /// <summary>
    /// The candidate applying.
    /// </summary>
    [JsonPropertyName("candidate")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Candidate>>))]
    public OneOf<string, Candidate>? Candidate { get; set; }

    /// <summary>
    /// The job being applied for.
    /// </summary>
    [JsonPropertyName("job")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Job>>))]
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
    [JsonConverter(
        typeof(CollectionItemSerializer<
            OneOf<string, Offer>,
            OneOfSerializer<OneOf<string, Offer>>
        >)
    )]
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
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, RemoteUser>>))]
    public OneOf<string, RemoteUser>? CreditedTo { get; set; }

    [JsonPropertyName("screening_question_answers")]
    [JsonConverter(
        typeof(CollectionItemSerializer<
            OneOf<string, ScreeningQuestionAnswerRequest>,
            OneOfSerializer<OneOf<string, ScreeningQuestionAnswerRequest>>
        >)
    )]
    public IEnumerable<
        OneOf<string, ScreeningQuestionAnswerRequest>
    >? ScreeningQuestionAnswers { get; set; }

    /// <summary>
    /// The application's current stage.
    /// </summary>
    [JsonPropertyName("current_stage")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, JobInterviewStage>>))]
    public OneOf<string, JobInterviewStage>? CurrentStage { get; set; }

    /// <summary>
    /// The application's reason for rejection.
    /// </summary>
    [JsonPropertyName("reject_reason")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, RejectReason>>))]
    public OneOf<string, RejectReason>? RejectReason { get; set; }

    [JsonPropertyName("remote_template_id")]
    public string? RemoteTemplateId { get; set; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }
}
