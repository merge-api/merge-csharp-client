using System.Text.Json.Serialization;
using Merge.Client.Filestorage;
using OneOf;

#nullable enable

namespace Merge.Client.Filestorage;

public class FileRequest
{
    /// <summary>
    /// The file's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The URL to access the file.
    /// </summary>
    [JsonPropertyName("file_url")]
    public string? FileUrl { get; init; }

    /// <summary>
    /// The URL that produces a thumbnail preview of the file. Typically an image.
    /// </summary>
    [JsonPropertyName("file_thumbnail_url")]
    public string? FileThumbnailUrl { get; init; }

    /// <summary>
    /// The file's size, in bytes.
    /// </summary>
    [JsonPropertyName("size")]
    public int? Size { get; init; }

    /// <summary>
    /// The file's mime type.
    /// </summary>
    [JsonPropertyName("mime_type")]
    public string? MimeType { get; init; }

    /// <summary>
    /// The file's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The folder that the file belongs to.
    /// </summary>
    [JsonPropertyName("folder")]
    public OneOf<string, Folder>? Folder { get; init; }

    /// <summary>
    /// The Permission object is used to represent a user's or group's access to a File or Folder. Permissions are unexpanded by default. Use the query param `expand=permissions` to see more details under `GET /files`.
    /// </summary>
    [JsonPropertyName("permissions")]
    public OneOf<
        string,
        PermissionRequest,
        List<OneOf<string, PermissionRequest>>
    >? Permissions { get; init; }

    /// <summary>
    /// The drive that the file belongs to.
    /// </summary>
    [JsonPropertyName("drive")]
    public OneOf<string, Drive>? Drive { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }
}
