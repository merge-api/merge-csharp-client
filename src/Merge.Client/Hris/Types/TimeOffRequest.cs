using System.Text.Json.Serialization;
using OneOf;
using Merge.Client.Hris;

namespace Merge.Client.Hris;

public class TimeOffRequest
{
    /// <summary>
    /// The employee requesting time off.
    /// </summary>
    [JsonPropertyName("employee")]
    public OneOf<string, Employee>? Employee { get; init; }

    /// <summary>
    /// The Merge ID of the employee with the ability to approve the time off request.
    /// </summary>
    [JsonPropertyName("approver")]
    public OneOf<string, Employee>? Approver { get; init; }

    /// <summary>
    /// The status of this time off request.
    /// 
    /// - `REQUESTED` - REQUESTED
    /// - `APPROVED` - APPROVED
    /// - `DECLINED` - DECLINED
    /// - `CANCELLED` - CANCELLED
    /// - `DELETED` - DELETED
    /// </summary>
    [JsonPropertyName("status")]
    public TimeOffStatusEnum? Status { get; init; }

    /// <summary>
    /// The employee note for this time off request.
    /// </summary>
    [JsonPropertyName("employee_note")]
    public string? EmployeeNote { get; init; }

    /// <summary>
    /// The measurement that the third-party integration uses to count time requested.
    /// 
    /// - `HOURS` - HOURS
    /// - `DAYS` - DAYS
    /// </summary>
    [JsonPropertyName("units")]
    public UnitsEnum? Units { get; init; }

    /// <summary>
    /// The time off quantity measured by the prescribed “units”.
    /// </summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; init; }

    /// <summary>
    /// The type of time off request.
    /// 
    /// - `VACATION` - VACATION
    /// - `SICK` - SICK
    /// - `PERSONAL` - PERSONAL
    /// - `JURY_DUTY` - JURY_DUTY
    /// - `VOLUNTEER` - VOLUNTEER
    /// - `BEREAVEMENT` - BEREAVEMENT
    /// </summary>
    [JsonPropertyName("request_type")]
    public RequestTypeEnum? RequestType { get; init; }

    /// <summary>
    /// The day and time of the start of the time requested off.
    /// </summary>
    [JsonPropertyName("start_time")]
    public DateTime? StartTime { get; init; }

    /// <summary>
    /// The day and time of the end of the time requested off.
    /// </summary>
    [JsonPropertyName("end_time")]
    public DateTime? EndTime { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }
}
