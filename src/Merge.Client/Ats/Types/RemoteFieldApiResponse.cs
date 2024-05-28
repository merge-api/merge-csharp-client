using System.Text.Json.Serialization;
using Merge.Client.Ats;

#nullable enable

namespace Merge.Client.Ats;

public class RemoteFieldApiResponse
{
    [JsonPropertyName("Activity")]
    public List<RemoteFieldApi>? Activity { get; init; }

    [JsonPropertyName("Application")]
    public List<RemoteFieldApi>? Application { get; init; }

    [JsonPropertyName("Attachment")]
    public List<RemoteFieldApi>? Attachment { get; init; }

    [JsonPropertyName("Candidate")]
    public List<RemoteFieldApi>? Candidate { get; init; }

    [JsonPropertyName("Department")]
    public List<RemoteFieldApi>? Department { get; init; }

    [JsonPropertyName("EEOC")]
    public List<RemoteFieldApi>? Eeoc { get; init; }

    [JsonPropertyName("ScheduledInterview")]
    public List<RemoteFieldApi>? ScheduledInterview { get; init; }

    [JsonPropertyName("Job")]
    public List<RemoteFieldApi>? Job { get; init; }

    [JsonPropertyName("JobPosting")]
    public List<RemoteFieldApi>? JobPosting { get; init; }

    [JsonPropertyName("JobInterviewStage")]
    public List<RemoteFieldApi>? JobInterviewStage { get; init; }

    [JsonPropertyName("Offer")]
    public List<RemoteFieldApi>? Offer { get; init; }

    [JsonPropertyName("Office")]
    public List<RemoteFieldApi>? Office { get; init; }

    [JsonPropertyName("RejectReason")]
    public List<RemoteFieldApi>? RejectReason { get; init; }

    [JsonPropertyName("Scorecard")]
    public List<RemoteFieldApi>? Scorecard { get; init; }

    [JsonPropertyName("Tag")]
    public List<RemoteFieldApi>? Tag { get; init; }

    [JsonPropertyName("RemoteUser")]
    public List<RemoteFieldApi>? RemoteUser { get; init; }
}
