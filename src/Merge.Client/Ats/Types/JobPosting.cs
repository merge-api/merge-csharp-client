using System.Text.Json.Serialization;
using Merge.Client.Ats;
using OneOf;

namespace Merge.Client.Ats;

public class JobPosting
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
    /// The job posting’s title.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    /// <summary>
    /// The Url object is used to represent hyperlinks for a candidate to apply to a given job.
    /// </summary>
    [JsonPropertyName("job_posting_urls")]
    public List<OneOf<string, Url>>? JobPostingUrls { get; init; }

    /// <summary>
    /// ID of `Job` object for this `JobPosting`.
    /// </summary>
    [JsonPropertyName("job")]
    public OneOf<string, Job>? Job { get; init; }

    /// <summary>
    /// The job posting's status.
    ///
    /// - `PUBLISHED` - PUBLISHED
    /// - `CLOSED` - CLOSED
    /// - `DRAFT` - DRAFT
    /// - `INTERNAL` - INTERNAL
    /// - `PENDING` - PENDING
    /// </summary>
    [JsonPropertyName("status")]
    public JobPostingStatusEnum? Status { get; init; }

    /// <summary>
    /// The job posting’s content.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; init; }

    /// <summary>
    /// When the third party's job posting was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; init; }

    /// <summary>
    /// When the third party's job posting was updated.
    /// </summary>
    [JsonPropertyName("remote_updated_at")]
    public DateTime? RemoteUpdatedAt { get; init; }

    /// <summary>
    /// Indicates whether the job posting is internal or external.
    /// </summary>
    [JsonPropertyName("is_internal")]
    public bool? IsInternal { get; init; }

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
