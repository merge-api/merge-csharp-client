using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

public record PayrollRun
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
    /// The state of the payroll run
    ///
    /// - `PAID` - PAID
    /// - `DRAFT` - DRAFT
    /// - `APPROVED` - APPROVED
    /// - `FAILED` - FAILED
    /// - `CLOSED` - CLOSED
    /// </summary>
    [JsonPropertyName("run_state")]
    public RunStateEnum? RunState { get; set; }

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
    public RunTypeEnum? RunType { get; set; }

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

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
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
