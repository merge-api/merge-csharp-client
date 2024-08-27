using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Crm;

public record Lead
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
    /// The lead's owner.
    /// </summary>
    [JsonPropertyName("owner")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, User>>))]
    public OneOf<string, User>? Owner { get; set; }

    /// <summary>
    /// The lead's source.
    /// </summary>
    [JsonPropertyName("lead_source")]
    public string? LeadSource { get; set; }

    /// <summary>
    /// The lead's title.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// The lead's company.
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; set; }

    /// <summary>
    /// The lead's first name.
    /// </summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    /// <summary>
    /// The lead's last name.
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("addresses")]
    public IEnumerable<Address>? Addresses { get; set; }

    [JsonPropertyName("email_addresses")]
    public IEnumerable<EmailAddress>? EmailAddresses { get; set; }

    [JsonPropertyName("phone_numbers")]
    public IEnumerable<PhoneNumber>? PhoneNumbers { get; set; }

    /// <summary>
    /// When the third party's lead was updated.
    /// </summary>
    [JsonPropertyName("remote_updated_at")]
    public DateTime? RemoteUpdatedAt { get; set; }

    /// <summary>
    /// When the third party's lead was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; set; }

    /// <summary>
    /// When the lead was converted.
    /// </summary>
    [JsonPropertyName("converted_date")]
    public DateTime? ConvertedDate { get; set; }

    /// <summary>
    /// The contact of the converted lead.
    /// </summary>
    [JsonPropertyName("converted_contact")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Contact>>))]
    public OneOf<string, Contact>? ConvertedContact { get; set; }

    /// <summary>
    /// The account of the converted lead.
    /// </summary>
    [JsonPropertyName("converted_account")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Account>>))]
    public OneOf<string, Account>? ConvertedAccount { get; set; }

    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

    [JsonPropertyName("remote_fields")]
    public IEnumerable<RemoteField>? RemoteFields { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
