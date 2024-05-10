using System.Text.Json.Serialization;
using Merge.Client.Ats;
using OneOf;

namespace Merge.Client.Ats;

public class ApplicationRequest
{
    /// <summary>
    /// The candidate applying.
    /// </summary>
    [JsonPropertyName("candidate")]
    public OneOf<string, Candidate>? Candidate { get; init; }

    /// <summary>
    /// The job being applied for.
    /// </summary>
    [JsonPropertyName("job")]
    public OneOf<string, Job>? Job { get; init; }

    /// <summary>
    /// When the application was submitted.
    /// </summary>
    [JsonPropertyName("applied_at")]
    public DateTime? AppliedAt { get; init; }

    /// <summary>
    /// When the application was rejected.
    /// </summary>
    [JsonPropertyName("rejected_at")]
    public DateTime? RejectedAt { get; init; }

    [JsonPropertyName("offers")]
    public List<OneOf<string, Offer>?>? Offers { get; init; }

    /// <summary>
    /// The application's source.
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; init; }

    /// <summary>
    /// The user credited for this application.
    /// </summary>
    [JsonPropertyName("credited_to")]
    public OneOf<string, RemoteUser>? CreditedTo { get; init; }

    /// <summary>
    /// The application's current stage.
    /// </summary>
    [JsonPropertyName("current_stage")]
    public OneOf<string, JobInterviewStage>? CurrentStage { get; init; }

    /// <summary>
    /// The application's reason for rejection.
    /// </summary>
    [JsonPropertyName("reject_reason")]
    public OneOf<string, RejectReason>? RejectReason { get; init; }

    [JsonPropertyName("remote_template_id")]
    public string? RemoteTemplateId { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }
}
