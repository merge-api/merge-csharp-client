using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Accounting;

public record Item
{
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
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// The item's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The item's status.
    ///
    /// - `ACTIVE` - ACTIVE
    /// - `ARCHIVED` - ARCHIVED
    /// </summary>
    [JsonPropertyName("status")]
    public Status7D1Enum? Status { get; set; }

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
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Account>>))]
    public OneOf<string, Account>? PurchaseAccount { get; set; }

    /// <summary>
    /// References the default account used to record a sale.
    /// </summary>
    [JsonPropertyName("sales_account")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Account>>))]
    public OneOf<string, Account>? SalesAccount { get; set; }

    /// <summary>
    /// The company the item belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, CompanyInfo>>))]
    public OneOf<string, CompanyInfo>? Company { get; set; }

    /// <summary>
    /// When the third party's item note was updated.
    /// </summary>
    [JsonPropertyName("remote_updated_at")]
    public DateTime? RemoteUpdatedAt { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }
}
