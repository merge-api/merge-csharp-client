using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Ats;

/// <summary>
/// # The JobPosting Object
/// ### Description
/// The `JobPosting` object represents an external announcement on a job board created by an organization to attract qualified candidates to apply for a specific `Job` opening
/// ### Usage Example
/// Fetch from the `LIST JobPostings` endpoint to show all job postings.
/// </summary>
public record JobPosting
{
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; set; }

    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// The job posting’s title.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// The Url object is used to represent hyperlinks for a candidate to apply to a given job.
    /// </summary>
    [JsonPropertyName("job_posting_urls")]
    public IEnumerable<OneOf<string, Url>>? JobPostingUrls { get; set; }

    /// <summary>
    /// ID of `Job` object for this `JobPosting`.
    /// </summary>
    [JsonPropertyName("job")]
    public OneOf<string, Job>? Job { get; set; }

    /// <summary>
    /// The job posting's status.
    ///
    /// * `PUBLISHED` - PUBLISHED
    /// * `CLOSED` - CLOSED
    /// * `DRAFT` - DRAFT
    /// * `INTERNAL` - INTERNAL
    /// * `PENDING` - PENDING
    /// </summary>
    [JsonPropertyName("status")]
    public OneOf<JobPostingStatusEnum, string>? Status { get; set; }

    /// <summary>
    /// The job posting’s content.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// When the third party's job posting was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; set; }

    /// <summary>
    /// When the third party's job posting was updated.
    /// </summary>
    [JsonPropertyName("remote_updated_at")]
    public DateTime? RemoteUpdatedAt { get; set; }

    /// <summary>
    /// Indicates whether the job posting is internal or external.
    /// </summary>
    [JsonPropertyName("is_internal")]
    public bool? IsInternal { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
