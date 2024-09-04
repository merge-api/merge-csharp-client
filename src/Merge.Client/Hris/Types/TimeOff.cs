using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Hris;

public record TimeOff
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
    /// The employee requesting time off.
    /// </summary>
    [JsonPropertyName("employee")]
    public OneOf<string, Employee>? Employee { get; set; }

    /// <summary>
    /// The Merge ID of the employee with the ability to approve the time off request.
    /// </summary>
    [JsonPropertyName("approver")]
    public OneOf<string, Employee>? Approver { get; set; }

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
    public TimeOffStatusEnum? Status { get; set; }

    /// <summary>
    /// The employee note for this time off request.
    /// </summary>
    [JsonPropertyName("employee_note")]
    public string? EmployeeNote { get; set; }

    /// <summary>
    /// The measurement that the third-party integration uses to count time requested.
    ///
    /// - `HOURS` - HOURS
    /// - `DAYS` - DAYS
    /// </summary>
    [JsonPropertyName("units")]
    public UnitsEnum? Units { get; set; }

    /// <summary>
    /// The time off quantity measured by the prescribed “units”.
    /// </summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; set; }

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
    public RequestTypeEnum? RequestType { get; set; }

    /// <summary>
    /// The day and time of the start of the time requested off.
    /// </summary>
    [JsonPropertyName("start_time")]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// The day and time of the end of the time requested off.
    /// </summary>
    [JsonPropertyName("end_time")]
    public DateTime? EndTime { get; set; }

    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
