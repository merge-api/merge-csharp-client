using System.Text.Json.Serialization;
using Merge.Client.Crm;
using OneOf;

namespace Merge.Client.Crm;

public class ContactRequest
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
    public List<AddressRequest>? Addresses { get; init; }

    [JsonPropertyName("email_addresses")]
    public List<EmailAddressRequest>? EmailAddresses { get; init; }

    [JsonPropertyName("phone_numbers")]
    public List<PhoneNumberRequest>? PhoneNumbers { get; init; }

    /// <summary>
    /// When the contact's last activity occurred.
    /// </summary>
    [JsonPropertyName("last_activity_at")]
    public DateTime? LastActivityAt { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }

    [JsonPropertyName("remote_fields")]
    public List<RemoteFieldRequest>? RemoteFields { get; init; }
}
