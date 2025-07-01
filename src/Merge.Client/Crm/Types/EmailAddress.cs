using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

/// <summary>
/// # The EmailAddress Object
/// ### Description
/// The `EmailAddress` object is used to represent an entity's email address.
/// ### Usage Example
/// Fetch from the `GET Contact` endpoint and view their email addresses.
/// </summary>
[Serializable]
public record EmailAddress
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
    /// The email address.
    /// </summary>
    [JsonPropertyName("email_address")]
    public string? EmailAddress_ { get; set; }

    /// <summary>
    /// The email address's type.
    /// </summary>
    [JsonPropertyName("email_address_type")]
    public string? EmailAddressType { get; set; }

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
