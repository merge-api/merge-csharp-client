using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

/// <summary>
/// # The Account Object
/// ### Description
/// The `Account` object is used to represent a company in a CRM system.
/// ### Usage Example
/// TODO
/// </summary>
[Serializable]
public record PatchedAccountRequest
{
    /// <summary>
    /// The account's owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

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

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

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
