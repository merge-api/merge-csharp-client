using System.Text.Json.Serialization;
using Merge.Client.Hris;
using OneOf;

namespace Merge.Client.Hris;

public class Benefit
{
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

    /// <summary>
    /// The employee on the plan.
    /// </summary>
    [JsonPropertyName("employee")]
    public OneOf<string, Employee>? Employee { get; init; }

    /// <summary>
    /// The name of the benefit provider.
    /// </summary>
    [JsonPropertyName("provider_name")]
    public string? ProviderName { get; init; }

    /// <summary>
    /// The type of benefit plan
    /// </summary>
    [JsonPropertyName("benefit_plan_type")]
    public string? BenefitPlanType { get; init; }

    /// <summary>
    /// The employee's contribution.
    /// </summary>
    [JsonPropertyName("employee_contribution")]
    public double? EmployeeContribution { get; init; }

    /// <summary>
    /// The company's contribution.
    /// </summary>
    [JsonPropertyName("company_contribution")]
    public double? CompanyContribution { get; init; }

    /// <summary>
    /// The day and time the benefit started.
    /// </summary>
    [JsonPropertyName("start_date")]
    public DateTime? StartDate { get; init; }

    /// <summary>
    /// The day and time the benefit ended.
    /// </summary>
    [JsonPropertyName("end_date")]
    public DateTime? EndDate { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    /// <summary>
    /// The employer benefit plan the employee is enrolled in.
    /// </summary>
    [JsonPropertyName("employer_benefit")]
    public string? EmployerBenefit { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public List<RemoteData>? RemoteData { get; init; }
}
