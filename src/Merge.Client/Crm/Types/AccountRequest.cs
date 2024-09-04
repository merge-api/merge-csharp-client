using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Crm;

public record AccountRequest
{
    /// <summary>
    /// The account's owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public OneOf<string, User>? Owner { get; set; }

    /// <summary>
    /// The account's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The account's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The account's industry.
    /// </summary>
    [JsonPropertyName("industry")]
    public string? Industry { get; set; }

    /// <summary>
    /// The account's website.
    /// </summary>
    [JsonPropertyName("website")]
    public string? Website { get; set; }

    /// <summary>
    /// The account's number of employees.
    /// </summary>
    [JsonPropertyName("number_of_employees")]
    public int? NumberOfEmployees { get; set; }

    [JsonPropertyName("addresses")]
    public IEnumerable<AddressRequest>? Addresses { get; set; }

    /// <summary>
    /// The last date (either most recent or furthest in the future) of when an activity occurs in an account.
    /// </summary>
    [JsonPropertyName("last_activity_at")]
    public DateTime? LastActivityAt { get; set; }

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
