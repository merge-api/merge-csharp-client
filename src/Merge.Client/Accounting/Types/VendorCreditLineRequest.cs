using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Accounting;

/// <summary>
/// # The VendorCreditLine Object
/// ### Description
/// The `VendorCreditLine` object is used to represent a vendor credit's line items.
///
/// ### Usage Example
/// Fetch from the `GET VendorCredit` endpoint and view the vendor credit's line items.
/// </summary>
[Serializable]
public record VendorCreditLineRequest
{
    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; set; }

    /// <summary>
    /// The full value of the credit.
    /// </summary>
    [JsonPropertyName("net_amount")]
    public double? NetAmount { get; set; }

    /// <summary>
    /// The line's associated tracking category.
    /// </summary>
    [JsonPropertyName("tracking_category")]
    public string? TrackingCategory { get; set; }

    /// <summary>
    /// The vendor credit line item's associated tracking categories.
    /// </summary>
    [JsonPropertyName("tracking_categories")]
    public IEnumerable<string>? TrackingCategories { get; set; }

    /// <summary>
    /// The line's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The line's account.
    /// </summary>
    [JsonPropertyName("account")]
    public OneOf<string, Account>? Account { get; set; }

    /// <summary>
    /// The company the line belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; set; }

    [JsonPropertyName("project")]
    public OneOf<string, Project>? Project { get; set; }

    [JsonPropertyName("contact")]
    public OneOf<string, Contact>? Contact { get; set; }

    /// <summary>
    /// The tax rate that applies to this line item.
    /// </summary>
    [JsonPropertyName("tax_rate")]
    public string? TaxRate { get; set; }

    /// <summary>
    /// The vendor credit line item's exchange rate.
    /// </summary>
    [JsonPropertyName("exchange_rate")]
    public string? ExchangeRate { get; set; }

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
