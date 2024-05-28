using System.Text.Json.Serialization;
using Merge.Client.Ats;

#nullable enable

namespace Merge.Client.Ats;

public class ExternalTargetFieldApiResponse
{
    [JsonPropertyName("Activity")]
    public List<ExternalTargetFieldApi>? Activity { get; init; }

    [JsonPropertyName("Application")]
    public List<ExternalTargetFieldApi>? Application { get; init; }

    [JsonPropertyName("Attachment")]
    public List<ExternalTargetFieldApi>? Attachment { get; init; }

    [JsonPropertyName("Candidate")]
    public List<ExternalTargetFieldApi>? Candidate { get; init; }

    [JsonPropertyName("Department")]
    public List<ExternalTargetFieldApi>? Department { get; init; }

    [JsonPropertyName("EEOC")]
    public List<ExternalTargetFieldApi>? Eeoc { get; init; }

    [JsonPropertyName("ScheduledInterview")]
    public List<ExternalTargetFieldApi>? ScheduledInterview { get; init; }

    [JsonPropertyName("Job")]
    public List<ExternalTargetFieldApi>? Job { get; init; }

    [JsonPropertyName("JobPosting")]
    public List<ExternalTargetFieldApi>? JobPosting { get; init; }

    [JsonPropertyName("JobInterviewStage")]
    public List<ExternalTargetFieldApi>? JobInterviewStage { get; init; }

    [JsonPropertyName("Offer")]
    public List<ExternalTargetFieldApi>? Offer { get; init; }

    [JsonPropertyName("Office")]
    public List<ExternalTargetFieldApi>? Office { get; init; }

    [JsonPropertyName("RejectReason")]
    public List<ExternalTargetFieldApi>? RejectReason { get; init; }

    [JsonPropertyName("Scorecard")]
    public List<ExternalTargetFieldApi>? Scorecard { get; init; }

    [JsonPropertyName("Tag")]
    public List<ExternalTargetFieldApi>? Tag { get; init; }

    [JsonPropertyName("RemoteUser")]
    public List<ExternalTargetFieldApi>? RemoteUser { get; init; }
}
