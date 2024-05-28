using System.Text.Json.Serialization;
using Merge.Client.Filestorage;
using OneOf;

#nullable enable

namespace Merge.Client.Filestorage;

public class FolderRequest
{
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
    public OneOf<
        string,
        PermissionRequest,
        List<OneOf<string, PermissionRequest>>
    >? Permissions { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }
}
