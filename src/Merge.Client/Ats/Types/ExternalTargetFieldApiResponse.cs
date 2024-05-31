using System.Text.Json.Serialization;
using Merge.Client.Ats;

#nullable enable

namespace Merge.Client.Ats;

public class ExternalTargetFieldApiResponse
{
    [JsonPropertyName("Activity")]
    public IEnumerable<ExternalTargetFieldApi>? Activity { get; init; }

    [JsonPropertyName("Application")]
    public IEnumerable<ExternalTargetFieldApi>? Application { get; init; }

    [JsonPropertyName("Attachment")]
    public IEnumerable<ExternalTargetFieldApi>? Attachment { get; init; }

    [JsonPropertyName("Candidate")]
    public IEnumerable<ExternalTargetFieldApi>? Candidate { get; init; }

    [JsonPropertyName("Department")]
    public IEnumerable<ExternalTargetFieldApi>? Department { get; init; }

    [JsonPropertyName("EEOC")]
    public IEnumerable<ExternalTargetFieldApi>? Eeoc { get; init; }

    [JsonPropertyName("ScheduledInterview")]
    public IEnumerable<ExternalTargetFieldApi>? ScheduledInterview { get; init; }

    [JsonPropertyName("Job")]
    public IEnumerable<ExternalTargetFieldApi>? Job { get; init; }

    [JsonPropertyName("JobPosting")]
    public IEnumerable<ExternalTargetFieldApi>? JobPosting { get; init; }

    [JsonPropertyName("JobInterviewStage")]
    public IEnumerable<ExternalTargetFieldApi>? JobInterviewStage { get; init; }

    [JsonPropertyName("Offer")]
    public IEnumerable<ExternalTargetFieldApi>? Offer { get; init; }

    [JsonPropertyName("Office")]
    public IEnumerable<ExternalTargetFieldApi>? Office { get; init; }

    [JsonPropertyName("RejectReason")]
    public IEnumerable<ExternalTargetFieldApi>? RejectReason { get; init; }

    [JsonPropertyName("Scorecard")]
    public IEnumerable<ExternalTargetFieldApi>? Scorecard { get; init; }

    [JsonPropertyName("Tag")]
    public IEnumerable<ExternalTargetFieldApi>? Tag { get; init; }

    [JsonPropertyName("RemoteUser")]
    public IEnumerable<ExternalTargetFieldApi>? RemoteUser { get; init; }
}
