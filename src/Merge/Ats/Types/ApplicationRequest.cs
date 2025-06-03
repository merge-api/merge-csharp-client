using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;
using OneOf;

namespace Merge.Ats;

/// <summary>
/// # The Application Object
/// ### Description
/// The Application Object is used to represent a candidate's journey through a particular Job's recruiting process. If a Candidate applies for multiple Jobs, there will be a separate Application for each Job if the third-party integration allows it.
///
/// ### Usage Example
/// Fetch from the `LIST Applications` endpoint and filter by `ID` to show all applications.
/// </summary>
public record ApplicationRequest
{
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
        OneOf<string, ScreeningQuestionAnswerRequest>
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

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("remote_template_id")]
    public string? RemoteTemplateId { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("integration_params")]
    public object? IntegrationParams { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("linked_account_params")]
    public object? LinkedAccountParams { get; set; }

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
