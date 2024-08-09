using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public record EmployerBenefit
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
    /// The type of benefit plan.
    ///
    /// - `MEDICAL` - MEDICAL
    /// - `HEALTH_SAVINGS` - HEALTH_SAVINGS
    /// - `INSURANCE` - INSURANCE
    /// - `RETIREMENT` - RETIREMENT
    /// - `OTHER` - OTHER
    /// </summary>
    [JsonPropertyName("benefit_plan_type")]
    public BenefitPlanTypeEnum? BenefitPlanType { get; set; }

    /// <summary>
    /// The employer benefit's name - typically the carrier or network name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The employer benefit's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The employer benefit's deduction code.
    /// </summary>
    [JsonPropertyName("deduction_code")]
    public string? DeductionCode { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<Dictionary<string, object?>>? RemoteData { get; set; }
}
