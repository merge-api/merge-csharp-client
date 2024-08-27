using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Crm;

public record LeadRequest
{
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
    public IEnumerable<AddressRequest>? Addresses { get; set; }

    [JsonPropertyName("email_addresses")]
    public IEnumerable<EmailAddressRequest>? EmailAddresses { get; set; }

    [JsonPropertyName("phone_numbers")]
    public IEnumerable<PhoneNumberRequest>? PhoneNumbers { get; set; }

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
