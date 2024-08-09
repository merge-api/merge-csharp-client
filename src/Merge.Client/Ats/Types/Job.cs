using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Ats;

public record Job
{
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
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// The job's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The job's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The job's code. Typically an additional identifier used to reference the particular job that is displayed on the ATS.
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

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
    public JobStatusEnum? Status { get; set; }

    /// <summary>
    /// The job's type.
    ///
    /// - `POSTING` - POSTING
    /// - `REQUISITION` - REQUISITION
    /// - `PROFILE` - PROFILE
    /// </summary>
    [JsonPropertyName("type")]
    public JobTypeEnum? Type { get; set; }

    /// <summary>
    /// IDs of `JobPosting` objects that serve as job postings for this `Job`.
    /// </summary>
    [JsonPropertyName("job_postings")]
    public IEnumerable<string>? JobPostings { get; set; }

    [JsonPropertyName("job_posting_urls")]
    public IEnumerable<Url>? JobPostingUrls { get; set; }

    /// <summary>
    /// When the third party's job was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; set; }

    /// <summary>
    /// When the third party's job was updated.
    /// </summary>
    [JsonPropertyName("remote_updated_at")]
    public DateTime? RemoteUpdatedAt { get; set; }

    /// <summary>
    /// Whether the job is confidential.
    /// </summary>
    [JsonPropertyName("confidential")]
    public bool? Confidential { get; set; }

    /// <summary>
    /// IDs of `Department` objects for this `Job`.
    /// </summary>
    [JsonPropertyName("departments")]
    [JsonConverter(
        typeof(CollectionItemSerializer<
            OneOf<string, Department>,
            OneOfSerializer<OneOf<string, Department>>
        >)
    )]
    public IEnumerable<OneOf<string, Department>>? Departments { get; set; }

    /// <summary>
    /// IDs of `Office` objects for this `Job`.
    /// </summary>
    [JsonPropertyName("offices")]
    [JsonConverter(
        typeof(CollectionItemSerializer<
            OneOf<string, Office>,
            OneOfSerializer<OneOf<string, Office>>
        >)
    )]
    public IEnumerable<OneOf<string, Office>>? Offices { get; set; }

    /// <summary>
    /// IDs of `RemoteUser` objects that serve as hiring managers for this `Job`.
    /// </summary>
    [JsonPropertyName("hiring_managers")]
    [JsonConverter(
        typeof(CollectionItemSerializer<
            OneOf<string, RemoteUser>,
            OneOfSerializer<OneOf<string, RemoteUser>>
        >)
    )]
    public IEnumerable<OneOf<string, RemoteUser>>? HiringManagers { get; set; }

    /// <summary>
    /// IDs of `RemoteUser` objects that serve as recruiters for this `Job`.
    /// </summary>
    [JsonPropertyName("recruiters")]
    [JsonConverter(
        typeof(CollectionItemSerializer<
            OneOf<string, RemoteUser>,
            OneOfSerializer<OneOf<string, RemoteUser>>
        >)
    )]
    public IEnumerable<OneOf<string, RemoteUser>>? Recruiters { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }
}
