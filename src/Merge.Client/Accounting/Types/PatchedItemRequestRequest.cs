using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Accounting;

/// <summary>
/// # The Item Object
/// ### Description
/// The `Item` object refers to the goods involved in a transaction.
///
/// ### Usage Example
/// Fetch from the `LIST Items` endpoint and view a company's items.
/// </summary>
public record PatchedItemRequestRequest
{
    /// <summary>
    /// The item's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The item's status.
    ///
    /// * `ACTIVE` - ACTIVE
    /// * `ARCHIVED` - ARCHIVED
    /// </summary>
    [JsonPropertyName("status")]
    public OneOf<Status7D1Enum, string>? Status { get; set; }

    /// <summary>
    /// The item's type.
    ///
    /// * `INVENTORY` - INVENTORY
    /// * `NON_INVENTORY` - NON_INVENTORY
    /// * `SERVICE` - SERVICE
    /// * `UNKNOWN` - UNKNOWN
    /// </summary>
    [JsonPropertyName("type")]
    public OneOf<Type2BbEnum, string>? Type { get; set; }

    /// <summary>
    /// The item's unit price.
    /// </summary>
    [JsonPropertyName("unit_price")]
    public double? UnitPrice { get; set; }

    /// <summary>
    /// The price at which the item is purchased from a vendor.
    /// </summary>
    [JsonPropertyName("purchase_price")]
    public double? PurchasePrice { get; set; }

    /// <summary>
    /// References the default account used to record a purchase of the item.
    /// </summary>
    [JsonPropertyName("purchase_account")]
    public string? PurchaseAccount { get; set; }

    /// <summary>
    /// References the default account used to record a sale.
    /// </summary>
    [JsonPropertyName("sales_account")]
    public string? SalesAccount { get; set; }

    /// <summary>
    /// The company the item belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; set; }

    /// <summary>
    /// The default purchase tax rate for this item.
    /// </summary>
    [JsonPropertyName("purchase_tax_rate")]
    public string? PurchaseTaxRate { get; set; }

    /// <summary>
    /// The default sales tax rate for this item.
    /// </summary>
    [JsonPropertyName("sales_tax_rate")]
    public string? SalesTaxRate { get; set; }

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
