using System.Text.Json.Serialization;
using Merge.Client.Ats;
using OneOf;

namespace Merge.Client.Ats;

public class JobInterviewStage
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// This is the datetime that this object was last updated by Merge
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    /// <summary>
    /// Standard stage names are offered by ATS systems but can be modified by users.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// This field is populated only if the stage is specific to a particular job. If the stage is generic, this field will not be populated.
    /// </summary>
    [JsonPropertyName("job")]
    public OneOf<string, Job>? Job { get; init; }

    /// <summary>
    /// The stage’s order, with the lowest values ordered first. If the third-party does not return details on the order of stages, this field will not be populated.
    /// </summary>
    [JsonPropertyName("stage_order")]
    public int? StageOrder { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public List<RemoteData>? RemoteData { get; init; }
}
