using System.Text.Json.Serialization;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

public class PayrollRun
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
    /// The state of the payroll run
    ///
    /// - `PAID` - PAID
    /// - `DRAFT` - DRAFT
    /// - `APPROVED` - APPROVED
    /// - `FAILED` - FAILED
    /// - `CLOSED` - CLOSED
    /// </summary>
    [JsonPropertyName("run_state")]
    public RunStateEnum? RunState { get; init; }

    /// <summary>
    /// The type of the payroll run
    ///
    /// - `REGULAR` - REGULAR
    /// - `OFF_CYCLE` - OFF_CYCLE
    /// - `CORRECTION` - CORRECTION
    /// - `TERMINATION` - TERMINATION
    /// - `SIGN_ON_BONUS` - SIGN_ON_BONUS
    /// </summary>
    [JsonPropertyName("run_type")]
    public RunTypeEnum? RunType { get; init; }

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
