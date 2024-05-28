using System.Text.Json.Serialization;
using Merge.Client.Ats;
using OneOf;

#nullable enable

namespace Merge.Client.Ats;

public class Job
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    /// <summary>
    /// The job's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The job's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The job's code. Typically an additional identifier used to reference the particular job that is displayed on the ATS.
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    /// <summary>
    /// The job's status.
    ///
    /// - `OPEN` - OPEN
    /// - `CLOSED` - CLOSED
    /// - `DRAFT` - DRAFT
    /// - `ARCHIVED` - ARCHIVED
    /// - `PENDING` - PENDING
    /// </summary>
    [JsonPropertyName("status")]
    public JobStatusEnum? Status { get; init; }

    /// <summary>
    /// The job's type.
    ///
    /// - `POSTING` - POSTING
    /// - `REQUISITION` - REQUISITION
    /// - `PROFILE` - PROFILE
    /// </summary>
    [JsonPropertyName("type")]
    public JobTypeEnum? Type { get; init; }

    /// <summary>
    /// IDs of `JobPosting` objects that serve as job postings for this `Job`.
    /// </summary>
    [JsonPropertyName("job_postings")]
    public List<string?>? JobPostings { get; init; }

    [JsonPropertyName("job_posting_urls")]
    public List<Url>? JobPostingUrls { get; init; }

    /// <summary>
    /// When the third party's job was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; init; }

    /// <summary>
    /// When the third party's job was updated.
    /// </summary>
    [JsonPropertyName("remote_updated_at")]
    public DateTime? RemoteUpdatedAt { get; init; }

    /// <summary>
    /// Whether the job is confidential.
    /// </summary>
    [JsonPropertyName("confidential")]
    public bool? Confidential { get; init; }

    /// <summary>
    /// IDs of `Department` objects for this `Job`.
    /// </summary>
    [JsonPropertyName("departments")]
    public List<OneOf<string, Department>?>? Departments { get; init; }

    /// <summary>
    /// IDs of `Office` objects for this `Job`.
    /// </summary>
    [JsonPropertyName("offices")]
    public List<OneOf<string, Office>?>? Offices { get; init; }

    /// <summary>
    /// IDs of `RemoteUser` objects that serve as hiring managers for this `Job`.
    /// </summary>
    [JsonPropertyName("hiring_managers")]
    public List<OneOf<string, RemoteUser>?>? HiringManagers { get; init; }

    /// <summary>
    /// IDs of `RemoteUser` objects that serve as recruiters for this `Job`.
    /// </summary>
    [JsonPropertyName("recruiters")]
    public List<OneOf<string, RemoteUser>?>? Recruiters { get; init; }

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
