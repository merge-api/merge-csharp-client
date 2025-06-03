using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting;

/// <summary>
/// # The TaxRate Object
/// ### Description
/// The `TaxComponent` object is used to represent any sub-taxes that make up the `TaxRate`.
///
/// ### Usage Example
/// Fetch from the `LIST TaxRates` endpoint and view tax components relevant to a tax rate.
/// </summary>
public record TaxComponent
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
    /// The tax rate’s name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The tax component’s rate.
    /// </summary>
    [JsonPropertyName("rate")]
    public string? Rate { get; set; }

    /// <summary>
    /// Returns True if the tax component is compound, False if not.
    /// </summary>
    [JsonPropertyName("is_compound")]
    public bool? IsCompound { get; set; }

    /// <summary>
    /// Returns PURCHASE if the tax component corresponds to a purchase tax or SALES if the tax component corresponds to a sales tax.
    ///
    /// * `SALES` - SALES
    /// * `PURCHASE` - PURCHASE
    /// </summary>
    [JsonPropertyName("component_type")]
    public ComponentTypeEnum? ComponentType { get; set; }

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
