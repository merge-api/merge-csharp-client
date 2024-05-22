using System.Text.Json.Serialization;
using Merge.Client.Accounting;
using OneOf;

namespace Merge.Client.Accounting;

public class CreditNoteLineItem
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    [JsonPropertyName("item")]
    public OneOf<string, Item>? Item { get; init; }

    /// <summary>
    /// The credit note line item's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The description of the item that is owed.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The credit note line item's quantity.
    /// </summary>
    [JsonPropertyName("quantity")]
    public string? Quantity { get; init; }

    /// <summary>
    /// The credit note line item's memo.
    /// </summary>
    [JsonPropertyName("memo")]
    public string? Memo { get; init; }

    /// <summary>
    /// The credit note line item's unit price.
    /// </summary>
    [JsonPropertyName("unit_price")]
    public string? UnitPrice { get; init; }

    /// <summary>
    /// The credit note line item's total.
    /// </summary>
    [JsonPropertyName("total_line_amount")]
    public string? TotalLineAmount { get; init; }

    /// <summary>
    /// The credit note line item's associated tracking category.
    /// </summary>
    [JsonPropertyName("tracking_category")]
    public string? TrackingCategory { get; init; }

    /// <summary>
    /// The credit note line item's associated tracking categories.
    /// </summary>
    [JsonPropertyName("tracking_categories")]
    public List<string> TrackingCategories { get; init; }

    /// <summary>
    /// The credit note line item's account.
    /// </summary>
    [JsonPropertyName("account")]
    public string? Account { get; init; }

    /// <summary>
    /// The company the credit note belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public OneOf<string, CompanyInfo>? Company { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }
}
