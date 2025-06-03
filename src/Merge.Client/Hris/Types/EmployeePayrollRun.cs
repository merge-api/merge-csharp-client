using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Hris;

/// <summary>
/// # The EmployeePayrollRun Object
/// ### Description
/// The `EmployeePayrollRun` object is used to represent an employee's pay statement for a specific payroll run.
///
/// ### Usage Example
/// Fetch from the `LIST EmployeePayrollRun` endpoint and filter by `ID` to show all employee payroll runs.
/// </summary>
public record EmployeePayrollRun
{
    [JsonAccess(JsonAccessType.ReadOnly)]
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
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// The employee whose payroll is being run.
    /// </summary>
    [JsonPropertyName("employee")]
    public OneOf<string, Employee>? Employee { get; set; }

    /// <summary>
    /// The payroll being run.
    /// </summary>
    [JsonPropertyName("payroll_run")]
    public OneOf<string, PayrollRun>? PayrollRun { get; set; }

    /// <summary>
    /// The total earnings throughout a given period for an employee before any deductions are made.
    /// </summary>
    [JsonPropertyName("gross_pay")]
    public double? GrossPay { get; set; }

    /// <summary>
    /// The take-home pay throughout a given period for an employee after deductions are made.
    /// </summary>
    [JsonPropertyName("net_pay")]
    public double? NetPay { get; set; }

    /// <summary>
    /// The day and time the payroll run started.
    /// </summary>
    [JsonPropertyName("start_date")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// The day and time the payroll run ended.
    /// </summary>
    [JsonPropertyName("end_date")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// The day and time the payroll run was checked.
    /// </summary>
    [JsonPropertyName("check_date")]
    public DateTime? CheckDate { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("earnings")]
    public IEnumerable<Earning>? Earnings { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("deductions")]
    public IEnumerable<Deduction>? Deductions { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("taxes")]
    public IEnumerable<Tax>? Taxes { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
