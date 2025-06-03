using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ats;

public record Issue
{
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Status of the issue. Options: ('ONGOING', 'RESOLVED')
    ///
    /// * `ONGOING` - ONGOING
    /// * `RESOLVED` - RESOLVED
    /// </summary>
    [JsonPropertyName("status")]
    public IssueStatusEnum? Status { get; set; }

    [JsonPropertyName("error_description")]
    public required string ErrorDescription { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("end_user")]
    public object? EndUser { get; set; }

    [JsonPropertyName("first_incident_time")]
    public DateTime? FirstIncidentTime { get; set; }

    [JsonPropertyName("last_incident_time")]
    public DateTime? LastIncidentTime { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("is_muted")]
    public bool? IsMuted { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("error_details")]
    public IEnumerable<string>? ErrorDetails { get; set; }

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
