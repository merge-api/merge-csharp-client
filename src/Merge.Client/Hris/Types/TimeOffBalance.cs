using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Hris;

/// <summary>
/// # The TimeOffBalance Object
/// ### Description
/// The `TimeOffBalance` object is used to represent current balances for an employee's Time Off plan.
///
/// ### Usage Example
/// Fetch from the `LIST TimeOffBalances` endpoint and filter by `ID` to show all time off balances.
/// </summary>
public record TimeOffBalance
{
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; set; }

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
    /// The employee the balance belongs to.
    /// </summary>
    [JsonPropertyName("employee")]
    public OneOf<string, Employee>? Employee { get; set; }

    /// <summary>
    /// The current remaining PTO balance, measured in hours. For integrations that return this value in days, Merge multiplies by 8 to calculate hours.
    /// </summary>
    [JsonPropertyName("balance")]
    public double? Balance { get; set; }

    /// <summary>
    /// The amount of PTO used in terms of hours. For integrations that return this value in days, Merge multiplies by 8 to calculate hours.
    /// </summary>
    [JsonPropertyName("used")]
    public double? Used { get; set; }

    /// <summary>
    /// The policy type of this time off balance.
    ///
    /// * `VACATION` - VACATION
    /// * `SICK` - SICK
    /// * `PERSONAL` - PERSONAL
    /// * `JURY_DUTY` - JURY_DUTY
    /// * `VOLUNTEER` - VOLUNTEER
    /// * `BEREAVEMENT` - BEREAVEMENT
    /// </summary>
    [JsonPropertyName("policy_type")]
    public PolicyTypeEnum? PolicyType { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

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
