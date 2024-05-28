using System.Text.Json.Serialization;
using Merge.Client.Ats;

#nullable enable

namespace Merge.Client.Ats;

public class FieldMappingApiInstanceResponse
{
    [JsonPropertyName("Activity")]
    public List<FieldMappingApiInstance>? Activity { get; init; }

    [JsonPropertyName("Application")]
    public List<FieldMappingApiInstance>? Application { get; init; }

    [JsonPropertyName("Attachment")]
    public List<FieldMappingApiInstance>? Attachment { get; init; }

    [JsonPropertyName("Candidate")]
    public List<FieldMappingApiInstance>? Candidate { get; init; }

    [JsonPropertyName("Department")]
    public List<FieldMappingApiInstance>? Department { get; init; }

    [JsonPropertyName("EEOC")]
    public List<FieldMappingApiInstance>? Eeoc { get; init; }

    [JsonPropertyName("ScheduledInterview")]
    public List<FieldMappingApiInstance>? ScheduledInterview { get; init; }

    [JsonPropertyName("Job")]
    public List<FieldMappingApiInstance>? Job { get; init; }

    [JsonPropertyName("JobPosting")]
    public List<FieldMappingApiInstance>? JobPosting { get; init; }

    [JsonPropertyName("JobInterviewStage")]
    public List<FieldMappingApiInstance>? JobInterviewStage { get; init; }

    [JsonPropertyName("Offer")]
    public List<FieldMappingApiInstance>? Offer { get; init; }

    [JsonPropertyName("Office")]
    public List<FieldMappingApiInstance>? Office { get; init; }

    [JsonPropertyName("RejectReason")]
    public List<FieldMappingApiInstance>? RejectReason { get; init; }

    [JsonPropertyName("Scorecard")]
    public List<FieldMappingApiInstance>? Scorecard { get; init; }

    [JsonPropertyName("Tag")]
    public List<FieldMappingApiInstance>? Tag { get; init; }

    [JsonPropertyName("RemoteUser")]
    public List<FieldMappingApiInstance>? RemoteUser { get; init; }
}
