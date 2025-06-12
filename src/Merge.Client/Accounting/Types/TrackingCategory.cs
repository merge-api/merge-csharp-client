using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Accounting;

/// <summary>
/// # The TrackingCategory Object
/// ### Description
/// A `TrackingCategory` object represents a categorization method used to classify transactions within an accounting platform. They are often used to group records for reporting and analysis purposes. The most common types of `TrackingCategories` are Classes and Departments.
///
/// ### Usage Example
/// Fetch from the `GET TrackingCategory` endpoint and view a company's tracking category.
/// </summary>
public record TrackingCategory
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
    /// The tracking category's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The tracking category's status.
    ///
    /// * `ACTIVE` - ACTIVE
    /// * `ARCHIVED` - ARCHIVED
    /// </summary>
    [JsonPropertyName("status")]
    public OneOf<Status7D1Enum, string>? Status { get; set; }

    /// <summary>
    /// The tracking category’s type.
    ///
    /// * `CLASS` - CLASS
    /// * `DEPARTMENT` - DEPARTMENT
    /// </summary>
    [JsonPropertyName("category_type")]
    public OneOf<CategoryTypeEnum, string>? CategoryType { get; set; }

    [JsonPropertyName("parent_category")]
    public string? ParentCategory { get; set; }

    /// <summary>
    /// The company the GeneralLedgerTransaction belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public OneOf<string, CompanyInfo>? Company { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

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
