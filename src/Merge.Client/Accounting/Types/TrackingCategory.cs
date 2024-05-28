using System.Text.Json.Serialization;
using Merge.Client.Accounting;
using OneOf;

#nullable enable

namespace Merge.Client.Accounting;

public class TrackingCategory
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
    /// The tracking category's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The tracking category's status.
    ///
    /// - `ACTIVE` - ACTIVE
    /// - `ARCHIVED` - ARCHIVED
    /// </summary>
    [JsonPropertyName("status")]
    public Status7D1Enum? Status { get; init; }

    /// <summary>
    /// The tracking category’s type.
    ///
    /// - `CLASS` - CLASS
    /// - `DEPARTMENT` - DEPARTMENT
    /// </summary>
    [JsonPropertyName("category_type")]
    public CategoryTypeEnum? CategoryType { get; init; }

    /// <summary>
    /// ID of the parent tracking category.
    /// </summary>
    [JsonPropertyName("parent_category")]
    public string? ParentCategory { get; init; }

    /// <summary>
    /// The company the tracking category belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public OneOf<string, CompanyInfo>? Company { get; init; }

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
