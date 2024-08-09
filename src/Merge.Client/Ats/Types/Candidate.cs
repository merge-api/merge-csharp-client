using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Ats;

public record Candidate
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
    /// The candidate's first name.
    /// </summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    /// <summary>
    /// The candidate's last name.
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    /// <summary>
    /// The candidate's current company.
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; set; }

    /// <summary>
    /// The candidate's current title.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// When the third party's candidate was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; set; }

    /// <summary>
    /// When the third party's candidate was updated.
    /// </summary>
    [JsonPropertyName("remote_updated_at")]
    public DateTime? RemoteUpdatedAt { get; set; }

    /// <summary>
    /// When the most recent interaction with the candidate occurred.
    /// </summary>
    [JsonPropertyName("last_interaction_at")]
    public DateTime? LastInteractionAt { get; set; }

    /// <summary>
    /// Whether or not the candidate is private.
    /// </summary>
    [JsonPropertyName("is_private")]
    public bool? IsPrivate { get; set; }

    /// <summary>
    /// Whether or not the candidate can be emailed.
    /// </summary>
    [JsonPropertyName("can_email")]
    public bool? CanEmail { get; set; }

    /// <summary>
    /// The candidate's locations.
    /// </summary>
    [JsonPropertyName("locations")]
    public IEnumerable<string>? Locations { get; set; }

    [JsonPropertyName("phone_numbers")]
    public IEnumerable<PhoneNumber>? PhoneNumbers { get; set; }

    [JsonPropertyName("email_addresses")]
    public IEnumerable<EmailAddress>? EmailAddresses { get; set; }

    [JsonPropertyName("urls")]
    public IEnumerable<Url>? Urls { get; set; }

    /// <summary>
    /// Array of `Tag` names as strings.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<string>? Tags { get; set; }

    /// <summary>
    /// Array of `Application` object IDs.
    /// </summary>
    [JsonPropertyName("applications")]
    [JsonConverter(
        typeof(CollectionItemSerializer<
            OneOf<string, Application>,
            OneOfSerializer<OneOf<string, Application>>
        >)
    )]
    public IEnumerable<OneOf<string, Application>>? Applications { get; set; }

    /// <summary>
    /// Array of `Attachment` object IDs.
    /// </summary>
    [JsonPropertyName("attachments")]
    [JsonConverter(
        typeof(CollectionItemSerializer<
            OneOf<string, Attachment>,
            OneOfSerializer<OneOf<string, Attachment>>
        >)
    )]
    public IEnumerable<OneOf<string, Attachment>>? Attachments { get; set; }

    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }
}
