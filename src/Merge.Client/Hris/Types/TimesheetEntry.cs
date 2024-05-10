using System.Text.Json.Serialization;

namespace Merge.Client.Hris;

public class TimesheetEntry
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
    /// The employee the timesheet entry is for.
    /// </summary>
    [JsonPropertyName("employee")]
    public string? Employee { get; init; }

    /// <summary>
    /// The number of hours logged by the employee.
    /// </summary>
    [JsonPropertyName("hours_worked")]
    public double? HoursWorked { get; init; }

    /// <summary>
    /// The time at which the employee started work.
    /// </summary>
    [JsonPropertyName("start_time")]
    public DateTime? StartTime { get; init; }

    /// <summary>
    /// The time at which the employee ended work.
    /// </summary>
    [JsonPropertyName("end_time")]
    public DateTime? EndTime { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public List<Dictionary<string, object>?>? RemoteData { get; init; }
}
