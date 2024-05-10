using System.Text.Json.Serialization;
using Merge.Client.Ats;
using OneOf;

namespace Merge.Client.Ats;

public class Offer
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// This is the datetime that this object was last updated by Merge
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    /// <summary>
    /// The application who is receiving the offer.
    /// </summary>
    [JsonPropertyName("application")]
    public OneOf<string, Application>? Application { get; init; }

    /// <summary>
    /// The user who created the offer.
    /// </summary>
    [JsonPropertyName("creator")]
    public OneOf<string, RemoteUser>? Creator { get; init; }

    /// <summary>
    /// When the third party's offer was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; init; }

    /// <summary>
    /// When the offer was closed.
    /// </summary>
    [JsonPropertyName("closed_at")]
    public DateTime? ClosedAt { get; init; }

    /// <summary>
    /// When the offer was sent.
    /// </summary>
    [JsonPropertyName("sent_at")]
    public DateTime? SentAt { get; init; }

    /// <summary>
    /// The employment start date on the offer.
    /// </summary>
    [JsonPropertyName("start_date")]
    public DateTime? StartDate { get; init; }

    /// <summary>
    /// The offer's status.
    ///
    /// - `DRAFT` - DRAFT
    /// - `APPROVAL-SENT` - APPROVAL-SENT
    /// - `APPROVED` - APPROVED
    /// - `SENT` - SENT
    /// - `SENT-MANUALLY` - SENT-MANUALLY
    /// - `OPENED` - OPENED
    /// - `DENIED` - DENIED
    /// - `SIGNED` - SIGNED
    /// - `DEPRECATED` - DEPRECATED
    /// </summary>
    [JsonPropertyName("status")]
    public OfferStatusEnum? Status { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public List<RemoteData>? RemoteData { get; init; }
}
