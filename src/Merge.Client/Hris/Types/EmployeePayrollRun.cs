using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Hris;
using OneOf;

#nullable enable

namespace Merge.Client.Hris;

public class EmployeePayrollRun
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
    /// The employee whose payroll is being run.
    /// </summary>
    [JsonPropertyName("employee")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Employee>>))]
    public OneOf<string, Employee>? Employee { get; init; }

    /// <summary>
    /// The payroll being run.
    /// </summary>
    [JsonPropertyName("payroll_run")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, PayrollRun>>))]
    public OneOf<string, PayrollRun>? PayrollRun { get; init; }

    /// <summary>
    /// The total earnings throughout a given period for an employee before any deductions are made.
    /// </summary>
    [JsonPropertyName("gross_pay")]
    public double? GrossPay { get; init; }

    /// <summary>
    /// The take-home pay throughout a given period for an employee after deductions are made.
    /// </summary>
    [JsonPropertyName("net_pay")]
    public double? NetPay { get; init; }

    /// <summary>
    /// The day and time the payroll run started.
    /// </summary>
    [JsonPropertyName("start_date")]
    public DateTime? StartDate { get; init; }

    /// <summary>
    /// The day and time the payroll run ended.
    /// </summary>
    [JsonPropertyName("end_date")]
    public DateTime? EndDate { get; init; }

    /// <summary>
    /// The day and time the payroll run was checked.
    /// </summary>
    [JsonPropertyName("check_date")]
    public DateTime? CheckDate { get; init; }

    [JsonPropertyName("earnings")]
    public IEnumerable<Earning>? Earnings { get; init; }

    [JsonPropertyName("deductions")]
    public IEnumerable<Deduction>? Deductions { get; init; }

    [JsonPropertyName("taxes")]
    public IEnumerable<Tax>? Taxes { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; init; }
}
