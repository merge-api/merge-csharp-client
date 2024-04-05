using System.Text.Json.Serialization;
using StringEnum;
using Merge.Client.Ticketing;
using OneOf;

namespace Merge.Client.Ticketing;

public class Collection
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    /// <summary>
    /// The collection's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The collection's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The collection's type.
    /// 
    /// - `LIST` - LIST
    /// - `PROJECT` - PROJECT
    /// </summary>
    [JsonPropertyName("collection_type")]
    public StringEnum<CollectionTypeEnum>? CollectionType { get; init; }

    /// <summary>
    /// The parent collection for this collection.
    /// </summary>
    [JsonPropertyName("parent_collection")]
    public OneOf<string, Collection>? ParentCollection { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    /// <summary>
    /// The level of access a User has to the Collection and its sub-objects.
    /// 
    /// - `PRIVATE` - PRIVATE
    /// - `COMPANY` - COMPANY
    /// - `PUBLIC` - PUBLIC
    /// </summary>
    [JsonPropertyName("access_level")]
    public StringEnum<AccessLevelEnum>? AccessLevel { get; init; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// This is the datetime that this object was last updated by Merge
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public List<RemoteData>? RemoteData { get; init; }
}
