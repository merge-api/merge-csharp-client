using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[Serializable]
public record ExternalTargetFieldApiResponse
{
    [JsonPropertyName("Activity")]
    public IEnumerable<ExternalTargetFieldApi>? Activity { get; set; }

    [JsonPropertyName("Application")]
    public IEnumerable<ExternalTargetFieldApi>? Application { get; set; }

    [JsonPropertyName("Attachment")]
    public IEnumerable<ExternalTargetFieldApi>? Attachment { get; set; }

    [JsonPropertyName("Candidate")]
    public IEnumerable<ExternalTargetFieldApi>? Candidate { get; set; }

    [JsonPropertyName("Department")]
    public IEnumerable<ExternalTargetFieldApi>? Department { get; set; }

    [JsonPropertyName("EEOC")]
    public IEnumerable<ExternalTargetFieldApi>? Eeoc { get; set; }

    [JsonPropertyName("ScheduledInterview")]
    public IEnumerable<ExternalTargetFieldApi>? ScheduledInterview { get; set; }

    [JsonPropertyName("Job")]
    public IEnumerable<ExternalTargetFieldApi>? Job { get; set; }

    [JsonPropertyName("JobPosting")]
    public IEnumerable<ExternalTargetFieldApi>? JobPosting { get; set; }

    [JsonPropertyName("JobInterviewStage")]
    public IEnumerable<ExternalTargetFieldApi>? JobInterviewStage { get; set; }

    [JsonPropertyName("Offer")]
    public IEnumerable<ExternalTargetFieldApi>? Offer { get; set; }

    [JsonPropertyName("Office")]
    public IEnumerable<ExternalTargetFieldApi>? Office { get; set; }

    [JsonPropertyName("RejectReason")]
    public IEnumerable<ExternalTargetFieldApi>? RejectReason { get; set; }

    [JsonPropertyName("Scorecard")]
    public IEnumerable<ExternalTargetFieldApi>? Scorecard { get; set; }

    [JsonPropertyName("Tag")]
    public IEnumerable<ExternalTargetFieldApi>? Tag { get; set; }

    [JsonPropertyName("RemoteUser")]
    public IEnumerable<ExternalTargetFieldApi>? RemoteUser { get; set; }

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
