using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.FileStorage;

/// <summary>
/// # The Folder Object
/// ### Description
/// The `Folder` object is used to represent a collection of files and/or folders in the workspace. Could be within a drive, if it exists.
/// ### Usage Example
/// Fetch from the `GET /api/filestorage/v1/folders` endpoint and view their folders.
/// </summary>
public record FolderRequest
{
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
    public OneOf<string, Folder>? ParentFolder { get; set; }

    /// <summary>
    /// The drive that the folder belongs to.
    /// </summary>
    [JsonPropertyName("drive")]
    public OneOf<string, Drive>? Drive { get; set; }

    /// <summary>
    /// The Permission object is used to represent a user's or group's access to a File or Folder. Permissions are unexpanded by default. Use the query param `expand=permissions` to see more details under `GET /folders`.
    /// </summary>
    [JsonPropertyName("permissions")]
    public OneOf<
        string,
        PermissionRequest,
        IEnumerable<OneOf<string, PermissionRequest>>
    >? Permissions { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

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
