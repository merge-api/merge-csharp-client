using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Hris;

public record Benefit
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
    /// The employee on the plan.
    /// </summary>
    [JsonPropertyName("employee")]
    public OneOf<string, Employee>? Employee { get; set; }

    /// <summary>
    /// The name of the benefit provider.
    /// </summary>
    [JsonPropertyName("provider_name")]
    public string? ProviderName { get; set; }

    /// <summary>
    /// The type of benefit plan
    /// </summary>
    [JsonPropertyName("benefit_plan_type")]
    public string? BenefitPlanType { get; set; }

    /// <summary>
    /// The employee's contribution.
    /// </summary>
    [JsonPropertyName("employee_contribution")]
    public double? EmployeeContribution { get; set; }

    /// <summary>
    /// The company's contribution.
    /// </summary>
    [JsonPropertyName("company_contribution")]
    public double? CompanyContribution { get; set; }

    /// <summary>
    /// The day and time the benefit started.
    /// </summary>
    [JsonPropertyName("start_date")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// The day and time the benefit ended.
    /// </summary>
    [JsonPropertyName("end_date")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    /// <summary>
    /// The employer benefit plan the employee is enrolled in.
    /// </summary>
    [JsonPropertyName("employer_benefit")]
    public string? EmployerBenefit { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
