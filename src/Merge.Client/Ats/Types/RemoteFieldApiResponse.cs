using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public record RemoteFieldApiResponse
{
    [JsonPropertyName("Activity")]
    public IEnumerable<RemoteFieldApi>? Activity { get; set; }

    [JsonPropertyName("Application")]
    public IEnumerable<RemoteFieldApi>? Application { get; set; }

    [JsonPropertyName("Attachment")]
    public IEnumerable<RemoteFieldApi>? Attachment { get; set; }

    [JsonPropertyName("Candidate")]
    public IEnumerable<RemoteFieldApi>? Candidate { get; set; }

    [JsonPropertyName("Department")]
    public IEnumerable<RemoteFieldApi>? Department { get; set; }

    [JsonPropertyName("EEOC")]
    public IEnumerable<RemoteFieldApi>? Eeoc { get; set; }

    [JsonPropertyName("ScheduledInterview")]
    public IEnumerable<RemoteFieldApi>? ScheduledInterview { get; set; }

    [JsonPropertyName("Job")]
    public IEnumerable<RemoteFieldApi>? Job { get; set; }

    [JsonPropertyName("JobPosting")]
    public IEnumerable<RemoteFieldApi>? JobPosting { get; set; }

    [JsonPropertyName("JobInterviewStage")]
    public IEnumerable<RemoteFieldApi>? JobInterviewStage { get; set; }

    [JsonPropertyName("Offer")]
    public IEnumerable<RemoteFieldApi>? Offer { get; set; }

    [JsonPropertyName("Office")]
    public IEnumerable<RemoteFieldApi>? Office { get; set; }

    [JsonPropertyName("RejectReason")]
    public IEnumerable<RemoteFieldApi>? RejectReason { get; set; }

    [JsonPropertyName("Scorecard")]
    public IEnumerable<RemoteFieldApi>? Scorecard { get; set; }

    [JsonPropertyName("Tag")]
    public IEnumerable<RemoteFieldApi>? Tag { get; set; }

    [JsonPropertyName("RemoteUser")]
    public IEnumerable<RemoteFieldApi>? RemoteUser { get; set; }
}
