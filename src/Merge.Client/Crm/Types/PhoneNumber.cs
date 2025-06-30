using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

/// <summary>
/// # The PhoneNumber Object
/// ### Description
/// The `PhoneNumber` object is used to represent an entity's phone number.
/// ### Usage Example
/// Fetch from the `GET Contact` endpoint and view their phone numbers.
/// </summary>
[Serializable]
public record PhoneNumber
{
    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// The phone number.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber_ { get; set; }

    /// <summary>
    /// The phone number's type.
    /// </summary>
    [JsonPropertyName("phone_number_type")]
    public string? PhoneNumberType { get; set; }

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
