using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Ats;

/// <summary>
/// # The EmailAddress Object
/// ### Description
/// The `EmailAddress` object is used to represent a candidate's email address.
/// ### Usage Example
/// Fetch from the `GET Candidate` endpoint and view their email addresses.
/// </summary>
[Serializable]
public record EmailAddressRequest
{
    /// <summary>
    /// The email address.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// The type of email address.
    ///
    /// * `PERSONAL` - PERSONAL
    /// * `WORK` - WORK
    /// * `OTHER` - OTHER
    /// </summary>
    [JsonPropertyName("email_address_type")]
    public OneOf<EmailAddressTypeEnum, string>? EmailAddressType { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

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
