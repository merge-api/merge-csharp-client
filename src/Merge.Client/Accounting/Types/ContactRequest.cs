using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Accounting;

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

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

    [JsonPropertyName("remote_fields")]
    public IEnumerable<RemoteFieldRequest>? RemoteFields { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
