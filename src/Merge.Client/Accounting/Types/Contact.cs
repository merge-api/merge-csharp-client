using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Accounting;

public record Contact
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
    /// The contact's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Whether the contact is a supplier.
    /// </summary>
    [JsonPropertyName("is_supplier")]
    public bool? IsSupplier { get; set; }

    /// <summary>
    /// Whether the contact is a customer.
    /// </summary>
    [JsonPropertyName("is_customer")]
    public bool? IsCustomer { get; set; }

    /// <summary>
    /// The contact's email address.
    /// </summary>
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; set; }

    /// <summary>
    /// The contact's tax number.
    /// </summary>
    [JsonPropertyName("tax_number")]
    public string? TaxNumber { get; set; }

    /// <summary>
    /// The contact's status
    ///
    /// - `ACTIVE` - ACTIVE
    /// - `ARCHIVED` - ARCHIVED
    /// </summary>
    [JsonPropertyName("status")]
    public Status7D1Enum? Status { get; set; }

    /// <summary>
    /// The currency the contact's transactions are in.
    /// </summary>
    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    /// <summary>
    /// When the third party's contact was updated.
    /// </summary>
    [JsonPropertyName("remote_updated_at")]
    public DateTime? RemoteUpdatedAt { get; set; }

    /// <summary>
    /// The company the contact belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; set; }

    /// <summary>
    /// `Address` object IDs for the given `Contacts` object.
    /// </summary>
    [JsonPropertyName("addresses")]
    [JsonConverter(
        typeof(CollectionItemSerializer<
            OneOf<string, Address>,
            OneOfSerializer<OneOf<string, Address>>
        >)
    )]
    public IEnumerable<OneOf<string, Address>>? Addresses { get; set; }

    /// <summary>
    /// `AccountingPhoneNumber` object for the given `Contacts` object.
    /// </summary>
    [JsonPropertyName("phone_numbers")]
    public IEnumerable<AccountingPhoneNumber>? PhoneNumbers { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
