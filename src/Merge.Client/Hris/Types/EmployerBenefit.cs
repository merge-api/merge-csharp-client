using System.Text.Json.Serialization;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

public class EmployerBenefit
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
    /// The type of benefit plan.
    ///
    /// - `MEDICAL` - MEDICAL
    /// - `HEALTH_SAVINGS` - HEALTH_SAVINGS
    /// - `INSURANCE` - INSURANCE
    /// - `RETIREMENT` - RETIREMENT
    /// - `OTHER` - OTHER
    /// </summary>
    [JsonPropertyName("benefit_plan_type")]
    public BenefitPlanTypeEnum? BenefitPlanType { get; init; }

    /// <summary>
    /// The employer benefit's name - typically the carrier or network name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The employer benefit's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The employer benefit's deduction code.
    /// </summary>
    [JsonPropertyName("deduction_code")]
    public string? DeductionCode { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<Dictionary<string, object>>? RemoteData { get; init; }
}
