using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Filestorage;

public record Issue
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Status of the issue. Options: ('ONGOING', 'RESOLVED')
    ///
    /// - `ONGOING` - ONGOING
    /// - `RESOLVED` - RESOLVED
    /// </summary>
    [JsonPropertyName("status")]
    public IssueStatusEnum? Status { get; set; }

    [JsonPropertyName("error_description")]
    public required string ErrorDescription { get; set; }

    [JsonPropertyName("end_user")]
    public Dictionary<string, object?>? EndUser { get; set; }

    [JsonPropertyName("first_incident_time")]
    public DateTime? FirstIncidentTime { get; set; }

    [JsonPropertyName("last_incident_time")]
    public DateTime? LastIncidentTime { get; set; }

    [JsonPropertyName("is_muted")]
    public bool? IsMuted { get; set; }

    [JsonPropertyName("error_details")]
    public IEnumerable<string>? ErrorDetails { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
