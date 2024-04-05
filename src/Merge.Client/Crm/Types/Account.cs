using System.Text.Json.Serialization;
using OneOf;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class Account
{
    /// <summary>
    /// The account's owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public OneOf<string, User>? Owner { get; init; }

    /// <summary>
    /// The account's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The account's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The account's industry.
    /// </summary>
    [JsonPropertyName("industry")]
    public string? Industry { get; init; }

    /// <summary>
    /// The account's website.
    /// </summary>
    [JsonPropertyName("website")]
    public string? Website { get; init; }

    /// <summary>
    /// The account's number of employees.
    /// </summary>
    [JsonPropertyName("number_of_employees")]
    public int? NumberOfEmployees { get; init; }

    [JsonPropertyName("addresses")]
    public List<Address>? Addresses { get; init; }

    [JsonPropertyName("phone_numbers")]
    public List<PhoneNumber>? PhoneNumbers { get; init; }

    /// <summary>
    /// The last date (either most recent or furthest in the future) of when an activity occurs in an account.
    /// </summary>
    [JsonPropertyName("last_activity_at")]
    public DateTime? LastActivityAt { get; init; }

    /// <summary>
    /// When the CRM system account data was last modified by a user with a login.
    /// </summary>
    [JsonPropertyName("remote_updated_at")]
    public DateTime? RemoteUpdatedAt { get; init; }

    /// <summary>
    /// When the third party's account was created.
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
