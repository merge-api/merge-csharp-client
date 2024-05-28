using System.Text.Json.Serialization;
using Merge.Client.Crm;
using OneOf;

#nullable enable

namespace Merge.Client.Crm;

public class AccountRequest
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
    public List<AddressRequest>? Addresses { get; init; }

    /// <summary>
    /// The last date (either most recent or furthest in the future) of when an activity occurs in an account.
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
