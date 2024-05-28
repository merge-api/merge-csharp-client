using System.Text.Json.Serialization;
using Merge.Client.Accounting;
using OneOf;

#nullable enable

namespace Merge.Client.Accounting;

public class TaxRate
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

    /// <summary>
    /// The tax rate's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The tax’s total tax rate - sum of the tax components (not compounded).
    /// </summary>
    [JsonPropertyName("total_tax_rate")]
    public double? TotalTaxRate { get; init; }

    /// <summary>
    /// The tax rate’s effective tax rate - total amount of tax with compounding.
    /// </summary>
    [JsonPropertyName("effective_tax_rate")]
    public double? EffectiveTaxRate { get; init; }

    /// <summary>
    /// The subsidiary that the tax rate belongs to (in the case of multi-entity systems).
    /// </summary>
    [JsonPropertyName("company")]
    public OneOf<string, CompanyInfo>? Company { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public List<RemoteData>? RemoteData { get; init; }
}
