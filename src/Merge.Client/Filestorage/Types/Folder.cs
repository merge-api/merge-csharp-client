using System.Text.Json.Serialization;
using OneOf;
using Merge.Client.Filestorage;

namespace Merge.Client.Filestorage;

public class Folder
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    /// <summary>
    /// The folder's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The URL to access the folder.
    /// </summary>
    [JsonPropertyName("folder_url")]
    public string? FolderUrl { get; init; }

    /// <summary>
    /// The folder's size, in bytes.
    /// </summary>
    [JsonPropertyName("size")]
    public int? Size { get; init; }

    /// <summary>
    /// The folder's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The folder that the folder belongs to.
    /// </summary>
    [JsonPropertyName("parent_folder")]
    public OneOf<string, Folder>? ParentFolder { get; init; }

    /// <summary>
    /// The drive that the folder belongs to.
    /// </summary>
    [JsonPropertyName("drive")]
    public OneOf<string, Drive>? Drive { get; init; }

    /// <summary>
    /// The Permission object is used to represent a user's or group's access to a File or Folder. Permissions are unexpanded by default. Use the query param `expand=permissions` to see more details under `GET /folders`.
    /// </summary>
    [JsonPropertyName("permissions")]
    public OneOf<string, PermissionRequest, List<OneOf<string, PermissionRequest>>>? Permissions { get; init; }

    /// <summary>
    /// When the third party's folder was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; init; }

    /// <summary>
    /// When the third party's folder was updated.
    /// </summary>
    [JsonPropertyName("remote_updated_at")]
    public DateTime? RemoteUpdatedAt { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

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
    public List<Dictionary<string, object>?>? RemoteData { get; init; }
}
