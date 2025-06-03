using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;
using OneOf;

namespace Merge.Accounting;

/// <summary>
/// # The CreditNoteLineItem Object
/// ### Description
/// The `CreditNoteLineItem` object is used to represent a credit note's line items.
///
/// ### Usage Example
/// Fetch from the `GET CreditNote` endpoint and view the credit note's line items.
/// </summary>
public record CreditNoteLineItemRequest
{
    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; set; }

    [JsonPropertyName("item")]
    public OneOf<string, Item>? Item { get; set; }

    /// <summary>
    /// The credit note line item's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The description of the item that is owed.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The credit note line item's quantity.
    /// </summary>
    [JsonPropertyName("quantity")]
    public string? Quantity { get; set; }

    /// <summary>
    /// The credit note line item's memo.
    /// </summary>
    [JsonPropertyName("memo")]
    public string? Memo { get; set; }

    /// <summary>
    /// The credit note line item's unit price.
    /// </summary>
    [JsonPropertyName("unit_price")]
    public string? UnitPrice { get; set; }

    /// <summary>
    /// The tax rate that applies to this line item.
    /// </summary>
    [JsonPropertyName("tax_rate")]
    public string? TaxRate { get; set; }

    /// <summary>
    /// The credit note line item's total.
    /// </summary>
    [JsonPropertyName("total_line_amount")]
    public string? TotalLineAmount { get; set; }

    /// <summary>
    /// The credit note line item's associated tracking category.
    /// </summary>
    [JsonPropertyName("tracking_category")]
    public string? TrackingCategory { get; set; }

    /// <summary>
    /// The credit note line item's associated tracking categories.
    /// </summary>
    [JsonPropertyName("tracking_categories")]
    public IEnumerable<string>? TrackingCategories { get; set; }

    /// <summary>
    /// The credit note line item's account.
    /// </summary>
    [JsonPropertyName("account")]
    public string? Account { get; set; }

    /// <summary>
    /// The company the credit note belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public OneOf<string, CompanyInfo>? Company { get; set; }

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
