using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;
using OneOf;

namespace Merge.Accounting;

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
public record ContactRequest
{
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
    public Status7D1Enum? Status { get; set; }

    /// <summary>
    /// The currency the contact's transactions are in.
    /// </summary>
    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

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
    public IEnumerable<AccountingPhoneNumberRequest>? PhoneNumbers { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("integration_params")]
    public object? IntegrationParams { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("linked_account_params")]
    public object? LinkedAccountParams { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("remote_fields")]
    public IEnumerable<RemoteFieldRequest>? RemoteFields { get; set; }

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
