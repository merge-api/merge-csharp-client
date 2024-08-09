using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Ticketing;

public record Collection
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
    /// The collection's type.
    ///
    /// - `LIST` - LIST
    /// - `PROJECT` - PROJECT
    /// </summary>
    [JsonPropertyName("collection_type")]
    public CollectionTypeEnum? CollectionType { get; set; }

    /// <summary>
    /// The parent collection for this collection.
    /// </summary>
    [JsonPropertyName("parent_collection")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Collection>>))]
    public OneOf<string, Collection>? ParentCollection { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    /// <summary>
    /// The level of access a User has to the Collection and its sub-objects.
    ///
    /// - `PRIVATE` - PRIVATE
    /// - `COMPANY` - COMPANY
    /// - `PUBLIC` - PUBLIC
    /// </summary>
    [JsonPropertyName("access_level")]
    public AccessLevelEnum? AccessLevel { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }
}
