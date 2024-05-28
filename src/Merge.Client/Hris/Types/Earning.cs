using System.Text.Json.Serialization;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

public class Earning
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

    [JsonPropertyName("employee_payroll_run")]
    public string? EmployeePayrollRun { get; init; }

    /// <summary>
    /// The amount earned.
    /// </summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; init; }

    /// <summary>
    /// The type of earning.
    ///
    /// - `SALARY` - SALARY
    /// - `REIMBURSEMENT` - REIMBURSEMENT
    /// - `OVERTIME` - OVERTIME
    /// - `BONUS` - BONUS
    /// </summary>
    [JsonPropertyName("type")]
    public EarningTypeEnum? Type { get; init; }

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
