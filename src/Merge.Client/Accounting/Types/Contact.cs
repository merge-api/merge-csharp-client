using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Accounting;

/// <summary>
/// # The Contact Object
/// ### Description
/// A `Contact` is an individual or business entity to which products and services are sold to or purchased from. The `Contact` model contains both Customers, in which products and services are sold to, and Vendors (or Suppliers), in which products and services are purchased from.
/// * A `Contact` is a Vendor/Supplier if the `is_supplier` property is true.
/// * A `Contact` is a customer if the `is_customer` property is true.
///
/// ### Usage Example
/// Fetch from the `LIST Contacts` endpoint and view a company's contacts.
/// </summary>
public record Contact
{
    [JsonAccess(JsonAccessType.ReadOnly)]
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
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
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
    /// * `ACTIVE` - ACTIVE
    /// * `ARCHIVED` - ARCHIVED
    /// </summary>
    [JsonPropertyName("status")]
    public OneOf<Status7D1Enum, string>? Status { get; set; }

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
    public IEnumerable<OneOf<string, Address>>? Addresses { get; set; }

    /// <summary>
    /// `AccountingPhoneNumber` object for the given `Contacts` object.
    /// </summary>
    [JsonPropertyName("phone_numbers")]
    public IEnumerable<AccountingPhoneNumber>? PhoneNumbers { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_fields")]
    public IEnumerable<RemoteField>? RemoteFields { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
