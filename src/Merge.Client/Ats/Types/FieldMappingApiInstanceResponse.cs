using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

public record FieldMappingApiInstanceResponse
{
    [JsonPropertyName("Activity")]
    public IEnumerable<FieldMappingApiInstance>? Activity { get; set; }

    [JsonPropertyName("Application")]
    public IEnumerable<FieldMappingApiInstance>? Application { get; set; }

    [JsonPropertyName("Attachment")]
    public IEnumerable<FieldMappingApiInstance>? Attachment { get; set; }

    [JsonPropertyName("Candidate")]
    public IEnumerable<FieldMappingApiInstance>? Candidate { get; set; }

    [JsonPropertyName("Department")]
    public IEnumerable<FieldMappingApiInstance>? Department { get; set; }

    [JsonPropertyName("EEOC")]
    public IEnumerable<FieldMappingApiInstance>? Eeoc { get; set; }

    [JsonPropertyName("ScheduledInterview")]
    public IEnumerable<FieldMappingApiInstance>? ScheduledInterview { get; set; }

    [JsonPropertyName("Job")]
    public IEnumerable<FieldMappingApiInstance>? Job { get; set; }

    [JsonPropertyName("JobPosting")]
    public IEnumerable<FieldMappingApiInstance>? JobPosting { get; set; }

    [JsonPropertyName("JobInterviewStage")]
    public IEnumerable<FieldMappingApiInstance>? JobInterviewStage { get; set; }

    [JsonPropertyName("Offer")]
    public IEnumerable<FieldMappingApiInstance>? Offer { get; set; }

    [JsonPropertyName("Office")]
    public IEnumerable<FieldMappingApiInstance>? Office { get; set; }

    [JsonPropertyName("RejectReason")]
    public IEnumerable<FieldMappingApiInstance>? RejectReason { get; set; }

    [JsonPropertyName("Scorecard")]
    public IEnumerable<FieldMappingApiInstance>? Scorecard { get; set; }

    [JsonPropertyName("Tag")]
    public IEnumerable<FieldMappingApiInstance>? Tag { get; set; }

    [JsonPropertyName("RemoteUser")]
    public IEnumerable<FieldMappingApiInstance>? RemoteUser { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
