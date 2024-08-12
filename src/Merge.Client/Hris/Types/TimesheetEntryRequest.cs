using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public record TimesheetEntryRequest
{
    /// <summary>
    /// The employee the timesheet entry is for.
    /// </summary>
    [JsonPropertyName("employee")]
    public string? Employee { get; set; }

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

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }
}
