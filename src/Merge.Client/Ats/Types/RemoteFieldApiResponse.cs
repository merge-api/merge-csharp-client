using System.Text.Json.Serialization;
using Merge.Client.Ats;

#nullable enable

namespace Merge.Client.Ats;

public class RemoteFieldApiResponse
{
    [JsonPropertyName("Activity")]
    public IEnumerable<RemoteFieldApi>? Activity { get; init; }

    [JsonPropertyName("Application")]
    public IEnumerable<RemoteFieldApi>? Application { get; init; }

    [JsonPropertyName("Attachment")]
    public IEnumerable<RemoteFieldApi>? Attachment { get; init; }

    [JsonPropertyName("Candidate")]
    public IEnumerable<RemoteFieldApi>? Candidate { get; init; }

    [JsonPropertyName("Department")]
    public IEnumerable<RemoteFieldApi>? Department { get; init; }

    [JsonPropertyName("EEOC")]
    public IEnumerable<RemoteFieldApi>? Eeoc { get; init; }

    [JsonPropertyName("ScheduledInterview")]
    public IEnumerable<RemoteFieldApi>? ScheduledInterview { get; init; }

    [JsonPropertyName("Job")]
    public IEnumerable<RemoteFieldApi>? Job { get; init; }

    [JsonPropertyName("JobPosting")]
    public IEnumerable<RemoteFieldApi>? JobPosting { get; init; }

    [JsonPropertyName("JobInterviewStage")]
    public IEnumerable<RemoteFieldApi>? JobInterviewStage { get; init; }

    [JsonPropertyName("Offer")]
    public IEnumerable<RemoteFieldApi>? Offer { get; init; }

    [JsonPropertyName("Office")]
    public IEnumerable<RemoteFieldApi>? Office { get; init; }

    [JsonPropertyName("RejectReason")]
    public IEnumerable<RemoteFieldApi>? RejectReason { get; init; }

    [JsonPropertyName("Scorecard")]
    public IEnumerable<RemoteFieldApi>? Scorecard { get; init; }

    [JsonPropertyName("Tag")]
    public IEnumerable<RemoteFieldApi>? Tag { get; init; }

    [JsonPropertyName("RemoteUser")]
    public IEnumerable<RemoteFieldApi>? RemoteUser { get; init; }
}
