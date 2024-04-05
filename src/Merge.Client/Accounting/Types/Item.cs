using System.Text.Json.Serialization;
using Merge.Client.Accounting;
using OneOf;

namespace Merge.Client.Accounting;

public class Item
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    /// <summary>
    /// The item's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The item's status.
    /// 
    /// - `ACTIVE` - ACTIVE
    /// - `ARCHIVED` - ARCHIVED
    /// </summary>
    [JsonPropertyName("status")]
    public Status7D1Enum? Status { get; init; }

    /// <summary>
    /// The item's unit price.
    /// </summary>
    [JsonPropertyName("unit_price")]
    public double? UnitPrice { get; init; }

    /// <summary>
    /// The price at which the item is purchased from a vendor.
    /// </summary>
    [JsonPropertyName("purchase_price")]
    public double? PurchasePrice { get; init; }

    /// <summary>
    /// References the default account used to record a purchase of the item.
    /// </summary>
    [JsonPropertyName("purchase_account")]
    public OneOf<string, Account>? PurchaseAccount { get; init; }

    /// <summary>
    /// References the default account used to record a sale.
    /// </summary>
    [JsonPropertyName("sales_account")]
    public OneOf<string, Account>? SalesAccount { get; init; }

    /// <summary>
    /// The company the item belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public OneOf<string, CompanyInfo>? Company { get; init; }

    /// <summary>
    /// When the third party's item note was updated.
    /// </summary>
    [JsonPropertyName("remote_updated_at")]
    public DateTime? RemoteUpdatedAt { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// This is the datetime that this object was last updated by Merge
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public List<RemoteData>? RemoteData { get; init; }
}
