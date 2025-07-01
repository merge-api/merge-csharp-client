using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Hris;

/// <summary>
/// # The Timesheet Entry Object
/// ### Description
/// The `Timesheet Entry` object is used to track coverage for hours worked by an 'Employee'.
///
///
/// ### Usage Example
/// GET and POST Timesheet Entries
/// </summary>
[Serializable]
public record TimesheetEntryRequest
{
    /// <summary>
    /// The employee the timesheet entry is for.
    /// </summary>
    [JsonPropertyName("employee")]
    public OneOf<string, Employee>? Employee { get; set; }

    /// <summary>
    /// The number of hours logged by the employee.
    /// </summary>
    [JsonPropertyName("hours_worked")]
    public double? HoursWorked { get; set; }

    /// <summary>
    /// The time at which the employee started work.
    /// </summary>
    [JsonPropertyName("start_time")]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// The time at which the employee ended work.
    /// </summary>
    [JsonPropertyName("end_time")]
    public DateTime? EndTime { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

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
