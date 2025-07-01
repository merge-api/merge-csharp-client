using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Ticketing;

/// <summary>
/// # The Collection Object
/// ### Description
/// The `Collection` object is used to represent one or more `Tickets`. There can be a hierarchy of `Collections`, in which a sub-collection belongs to a parent-collection.
///
/// ### Usage Example
/// TODO
/// </summary>
[Serializable]
public record Collection
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
    /// The collection's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The collection's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The level of access a User has to the Collection and its sub-objects.
    ///
    /// * `PRIVATE` - PRIVATE
    /// * `COMPANY` - COMPANY
    /// * `PUBLIC` - PUBLIC
    /// * `PARENT_COLLECTION` - PARENT_COLLECTION
    /// </summary>
    [JsonPropertyName("access_level")]
    public OneOf<CollectionAccessLevelEnum, string>? AccessLevel { get; set; }

    /// <summary>
    /// The collection's type.
    ///
    /// * `LIST` - LIST
    /// * `PROJECT` - PROJECT
    /// </summary>
    [JsonPropertyName("collection_type")]
    public CollectionTypeEnum? CollectionType { get; set; }

    /// <summary>
    /// The parent collection for this collection.
    /// </summary>
    [JsonPropertyName("parent_collection")]
    public OneOf<string, Collection>? ParentCollection { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
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
