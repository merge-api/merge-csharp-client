using System.Text.Json.Serialization;
using Merge.Client.Crm;
using OneOf;

namespace Merge.Client.Crm;

public class LeadRequest
{
    /// <summary>
    /// The lead's owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public OneOf<string, User>? Owner { get; init; }

    /// <summary>
    /// The lead's source.
    /// </summary>
    [JsonPropertyName("lead_source")]
    public string? LeadSource { get; init; }

    /// <summary>
    /// The lead's title.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    /// <summary>
    /// The lead's company.
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; init; }

    /// <summary>
    /// The lead's first name.
    /// </summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; init; }

    /// <summary>
    /// The lead's last name.
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; init; }

    [JsonPropertyName("addresses")]
    public List<AddressRequest>? Addresses { get; init; }

    [JsonPropertyName("email_addresses")]
    public List<EmailAddressRequest>? EmailAddresses { get; init; }

    [JsonPropertyName("phone_numbers")]
    public List<PhoneNumberRequest>? PhoneNumbers { get; init; }

    /// <summary>
    /// When the lead was converted.
    /// </summary>
    [JsonPropertyName("converted_date")]
    public DateTime? ConvertedDate { get; init; }

    /// <summary>
    /// The contact of the converted lead.
    /// </summary>
    [JsonPropertyName("converted_contact")]
    public OneOf<string, Contact>? ConvertedContact { get; init; }

    /// <summary>
    /// The account of the converted lead.
    /// </summary>
    [JsonPropertyName("converted_account")]
    public OneOf<string, Account>? ConvertedAccount { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }

    [JsonPropertyName("remote_fields")]
    public List<RemoteFieldRequest>? RemoteFields { get; init; }
}
