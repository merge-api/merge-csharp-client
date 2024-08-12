using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Filestorage;

public record Folder
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
    /// The folder's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The URL to access the folder.
    /// </summary>
    [JsonPropertyName("folder_url")]
    public string? FolderUrl { get; set; }

    /// <summary>
    /// The folder's size, in bytes.
    /// </summary>
    [JsonPropertyName("size")]
    public long? Size { get; set; }

    /// <summary>
    /// The folder's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The folder that the folder belongs to.
    /// </summary>
    [JsonPropertyName("parent_folder")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Folder>>))]
    public OneOf<string, Folder>? ParentFolder { get; set; }

    /// <summary>
    /// The drive that the folder belongs to.
    /// </summary>
    [JsonPropertyName("drive")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Drive>>))]
    public OneOf<string, Drive>? Drive { get; set; }

    /// <summary>
    /// The Permission object is used to represent a user's or group's access to a File or Folder. Permissions are unexpanded by default. Use the query param `expand=permissions` to see more details under `GET /folders`.
    /// </summary>
    [JsonPropertyName("permissions")]
    [JsonConverter(
        typeof(OneOfSerializer<
            OneOf<string, PermissionRequest, IEnumerable<OneOf<string, PermissionRequest>>>
        >)
    )]
    public OneOf<
        string,
        PermissionRequest,
        IEnumerable<OneOf<string, PermissionRequest>>
    >? Permissions { get; set; }

    /// <summary>
    /// When the third party's folder was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; set; }

    /// <summary>
    /// When the third party's folder was updated.
    /// </summary>
    [JsonPropertyName("remote_updated_at")]
    public DateTime? RemoteUpdatedAt { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<Dictionary<string, object?>>? RemoteData { get; set; }
}
