using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Ats;

public record Offer
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
    /// The application who is receiving the offer.
    /// </summary>
    [JsonPropertyName("application")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Application>>))]
    public OneOf<string, Application>? Application { get; set; }

    /// <summary>
    /// The user who created the offer.
    /// </summary>
    [JsonPropertyName("creator")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, RemoteUser>>))]
    public OneOf<string, RemoteUser>? Creator { get; set; }

    /// <summary>
    /// When the third party's offer was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; set; }

    /// <summary>
    /// When the offer was closed.
    /// </summary>
    [JsonPropertyName("closed_at")]
    public DateTime? ClosedAt { get; set; }

    /// <summary>
    /// When the offer was sent.
    /// </summary>
    [JsonPropertyName("sent_at")]
    public DateTime? SentAt { get; set; }

    /// <summary>
    /// The employment start date on the offer.
    /// </summary>
    [JsonPropertyName("start_date")]
    public DateTime? StartDate { get; set; }

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
    public OfferStatusEnum? Status { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }
}
