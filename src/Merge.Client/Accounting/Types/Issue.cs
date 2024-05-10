using System.Text.Json.Serialization;
using Merge.Client.Accounting;

namespace Merge.Client.Accounting;

public class Issue
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Status of the issue. Options: ('ONGOING', 'RESOLVED')
    ///
    /// - `ONGOING` - ONGOING
    /// - `RESOLVED` - RESOLVED
    /// </summary>
    [JsonPropertyName("status")]
    public IssueStatusEnum? Status { get; init; }

    [JsonPropertyName("error_description")]
    public string ErrorDescription { get; init; }

    [JsonPropertyName("end_user")]
    public Dictionary<string, object>? EndUser { get; init; }

    [JsonPropertyName("first_incident_time")]
    public DateTime? FirstIncidentTime { get; init; }

    [JsonPropertyName("last_incident_time")]
    public DateTime? LastIncidentTime { get; init; }

    [JsonPropertyName("is_muted")]
    public bool? IsMuted { get; init; }

    [JsonPropertyName("error_details")]
    public List<string>? ErrorDetails { get; init; }
}
