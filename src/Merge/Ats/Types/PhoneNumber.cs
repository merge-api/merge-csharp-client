using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ats;

/// <summary>
/// # The PhoneNumber Object
/// ### Description
/// The `PhoneNumber` object is used to represent a candidate's phone number.
/// ### Usage Example
/// Fetch from the `GET Candidate` endpoint and view their phone numbers.
/// </summary>
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
    public PhoneNumberTypeEnum? PhoneNumberType { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

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
