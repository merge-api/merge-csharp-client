using System.Text.Json.Serialization;
using OneOf;
using Merge.Client.Accounting;

namespace Merge.Client.Accounting;

public class TaxRate
{
    /// <summary>
    /// The tax rate's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The tax rate's total tax rate.
    /// </summary>
    [JsonPropertyName("total_tax_rate")]
    public double? TotalTaxRate { get; init; }

    /// <summary>
    /// The tax rate's effective tax rate.
    /// </summary>
    [JsonPropertyName("effective_tax_rate")]
    public double? EffectiveTaxRate { get; init; }

    /// <summary>
    /// The company the tax rate belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public OneOf<string, CompanyInfo>? Company { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

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
