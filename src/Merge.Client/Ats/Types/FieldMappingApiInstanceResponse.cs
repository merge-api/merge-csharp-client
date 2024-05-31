using System.Text.Json.Serialization;
using Merge.Client.Ats;

#nullable enable

namespace Merge.Client.Ats;

public class FieldMappingApiInstanceResponse
{
    [JsonPropertyName("Activity")]
    public IEnumerable<FieldMappingApiInstance>? Activity { get; init; }

    [JsonPropertyName("Application")]
    public IEnumerable<FieldMappingApiInstance>? Application { get; init; }

    [JsonPropertyName("Attachment")]
    public IEnumerable<FieldMappingApiInstance>? Attachment { get; init; }

    [JsonPropertyName("Candidate")]
    public IEnumerable<FieldMappingApiInstance>? Candidate { get; init; }

    [JsonPropertyName("Department")]
    public IEnumerable<FieldMappingApiInstance>? Department { get; init; }

    [JsonPropertyName("EEOC")]
    public IEnumerable<FieldMappingApiInstance>? Eeoc { get; init; }

    [JsonPropertyName("ScheduledInterview")]
    public IEnumerable<FieldMappingApiInstance>? ScheduledInterview { get; init; }

    [JsonPropertyName("Job")]
    public IEnumerable<FieldMappingApiInstance>? Job { get; init; }

    [JsonPropertyName("JobPosting")]
    public IEnumerable<FieldMappingApiInstance>? JobPosting { get; init; }

    [JsonPropertyName("JobInterviewStage")]
    public IEnumerable<FieldMappingApiInstance>? JobInterviewStage { get; init; }

    [JsonPropertyName("Offer")]
    public IEnumerable<FieldMappingApiInstance>? Offer { get; init; }

    [JsonPropertyName("Office")]
    public IEnumerable<FieldMappingApiInstance>? Office { get; init; }

    [JsonPropertyName("RejectReason")]
    public IEnumerable<FieldMappingApiInstance>? RejectReason { get; init; }

    [JsonPropertyName("Scorecard")]
    public IEnumerable<FieldMappingApiInstance>? Scorecard { get; init; }

    [JsonPropertyName("Tag")]
    public IEnumerable<FieldMappingApiInstance>? Tag { get; init; }

    [JsonPropertyName("RemoteUser")]
    public IEnumerable<FieldMappingApiInstance>? RemoteUser { get; init; }
}
