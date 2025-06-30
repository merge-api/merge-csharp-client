using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Ats;

/// <summary>
/// # The PhoneNumber Object
/// ### Description
/// The `PhoneNumber` object is used to represent a candidate's phone number.
/// ### Usage Example
/// Fetch from the `GET Candidate` endpoint and view their phone numbers.
/// </summary>
[Serializable]
public record PhoneNumberRequest
{
    /// <summary>
    /// The phone number.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// The type of phone number.
    ///
    /// * `HOME` - HOME
    /// * `WORK` - WORK
    /// * `MOBILE` - MOBILE
    /// * `SKYPE` - SKYPE
    /// * `OTHER` - OTHER
    /// </summary>
    [JsonPropertyName("phone_number_type")]
    public OneOf<PhoneNumberTypeEnum, string>? PhoneNumberType { get; set; }

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
