using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;
using OneOf;

namespace Merge.Ticketing;

/// <summary>
/// # The Contact Object
/// ### Description
/// The `Contact` object is used to represent the customer, lead, or external user that a ticket is associated with.
///
/// ### Usage Example
/// TODO
/// </summary>
public record ContactRequest
{
    /// <summary>
    /// The contact's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The contact's email address.
    /// </summary>
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; set; }

    /// <summary>
    /// The contact's phone number.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// The contact's details.
    /// </summary>
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    /// <summary>
    /// The contact's account.
    /// </summary>
    [JsonPropertyName("account")]
    public OneOf<string, Account>? Account { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("integration_params")]
    public object? IntegrationParams { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("linked_account_params")]
    public object? LinkedAccountParams { get; set; }

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
