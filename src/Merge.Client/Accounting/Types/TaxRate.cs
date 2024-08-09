using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Accounting;

public record TaxRate
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
    /// The tax rate's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The tax’s total tax rate - sum of the tax components (not compounded).
    /// </summary>
    [JsonPropertyName("total_tax_rate")]
    public double? TotalTaxRate { get; set; }

    /// <summary>
    /// The tax rate’s effective tax rate - total amount of tax with compounding.
    /// </summary>
    [JsonPropertyName("effective_tax_rate")]
    public double? EffectiveTaxRate { get; set; }

    /// <summary>
    /// The subsidiary that the tax rate belongs to (in the case of multi-entity systems).
    /// </summary>
    [JsonPropertyName("company")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, CompanyInfo>>))]
    public OneOf<string, CompanyInfo>? Company { get; set; }

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
