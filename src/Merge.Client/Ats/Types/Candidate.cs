using System.Text.Json.Serialization;
using Merge.Client.Ats;
using OneOf;

namespace Merge.Client.Ats;

public class Candidate
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
    /// The candidate's first name.
    /// </summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; init; }

    /// <summary>
    /// The candidate's last name.
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; init; }

    /// <summary>
    /// The candidate's current company.
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; init; }

    /// <summary>
    /// The candidate's current title.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    /// <summary>
    /// When the third party's candidate was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; init; }

    /// <summary>
    /// When the third party's candidate was updated.
    /// </summary>
    [JsonPropertyName("remote_updated_at")]
    public DateTime? RemoteUpdatedAt { get; init; }

    /// <summary>
    /// When the most recent interaction with the candidate occurred.
    /// </summary>
    [JsonPropertyName("last_interaction_at")]
    public DateTime? LastInteractionAt { get; init; }

    /// <summary>
    /// Whether or not the candidate is private.
    /// </summary>
    [JsonPropertyName("is_private")]
    public bool? IsPrivate { get; init; }

    /// <summary>
    /// Whether or not the candidate can be emailed.
    /// </summary>
    [JsonPropertyName("can_email")]
    public bool? CanEmail { get; init; }

    /// <summary>
    /// The candidate's locations.
    /// </summary>
    [JsonPropertyName("locations")]
    public List<string?>? Locations { get; init; }

    [JsonPropertyName("phone_numbers")]
    public List<PhoneNumber>? PhoneNumbers { get; init; }

    [JsonPropertyName("email_addresses")]
    public List<EmailAddress>? EmailAddresses { get; init; }

    [JsonPropertyName("urls")]
    public List<Url>? Urls { get; init; }

    /// <summary>
    /// Array of `Tag` names as strings.
    /// </summary>
    [JsonPropertyName("tags")]
    public List<string?>? Tags { get; init; }

    /// <summary>
    /// Array of `Application` object IDs.
    /// </summary>
    [JsonPropertyName("applications")]
    public List<OneOf<string, Application>?>? Applications { get; init; }

    /// <summary>
    /// Array of `Attachment` object IDs.
    /// </summary>
    [JsonPropertyName("attachments")]
    public List<OneOf<string, Attachment>?>? Attachments { get; init; }

    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public List<RemoteData>? RemoteData { get; init; }
}
