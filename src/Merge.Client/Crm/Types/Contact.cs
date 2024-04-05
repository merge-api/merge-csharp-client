using System.Text.Json.Serialization;
using OneOf;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class Contact
{
    /// <summary>
    /// The contact's first name.
    /// </summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; init; }

    /// <summary>
    /// The contact's last name.
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; init; }

    /// <summary>
    /// The contact's account.
    /// </summary>
    [JsonPropertyName("account")]
    public OneOf<string, Account>? Account { get; init; }

    /// <summary>
    /// The contact's owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public OneOf<string, User>? Owner { get; init; }

    [JsonPropertyName("addresses")]
    public List<Address>? Addresses { get; init; }

    [JsonPropertyName("email_addresses")]
    public List<EmailAddress>? EmailAddresses { get; init; }

    [JsonPropertyName("phone_numbers")]
    public List<PhoneNumber>? PhoneNumbers { get; init; }

    /// <summary>
    /// When the contact's last activity occurred.
    /// </summary>
    [JsonPropertyName("last_activity_at")]
    public DateTime? LastActivityAt { get; init; }

    /// <summary>
    /// When the third party's contact was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; init; }

    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

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

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public List<RemoteData>? RemoteData { get; init; }

    [JsonPropertyName("remote_fields")]
    public List<RemoteField>? RemoteFields { get; init; }
}
