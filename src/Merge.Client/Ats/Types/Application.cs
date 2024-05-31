using System.Text.Json.Serialization;
using Merge.Client.Ats;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Ats;

public class Application
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    /// <summary>
    /// The candidate applying.
    /// </summary>
    [JsonPropertyName("candidate")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Candidate>>))]
    public OneOf<string, Candidate>? Candidate { get; init; }

    /// <summary>
    /// The job being applied for.
    /// </summary>
    [JsonPropertyName("job")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Job>>))]
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
    [JsonConverter(
        typeof(CollectionItemSerializer<
            OneOf<string, Offer>,
            OneOfSerializer<OneOf<string, Offer>>
        >)
    )]
    public IEnumerable<OneOf<string, Offer>>? Offers { get; init; }

    /// <summary>
    /// The application's source.
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; init; }

    /// <summary>
    /// The user credited for this application.
    /// </summary>
    [JsonPropertyName("credited_to")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, RemoteUser>>))]
    public OneOf<string, RemoteUser>? CreditedTo { get; init; }

    /// <summary>
    /// The application's current stage.
    /// </summary>
    [JsonPropertyName("current_stage")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, JobInterviewStage>>))]
    public OneOf<string, JobInterviewStage>? CurrentStage { get; init; }

    /// <summary>
    /// The application's reason for rejection.
    /// </summary>
    [JsonPropertyName("reject_reason")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, RejectReason>>))]
    public OneOf<string, RejectReason>? RejectReason { get; init; }

    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; init; }
}
