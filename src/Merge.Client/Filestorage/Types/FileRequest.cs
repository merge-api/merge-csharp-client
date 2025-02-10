using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Filestorage;

public record FileRequest
{
    /// <summary>
    /// The file's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The URL to access the file.
    /// </summary>
    [JsonPropertyName("file_url")]
    public string? FileUrl { get; set; }

    /// <summary>
    /// The URL that produces a thumbnail preview of the file. Typically an image.
    /// </summary>
    [JsonPropertyName("file_thumbnail_url")]
    public string? FileThumbnailUrl { get; set; }

    /// <summary>
    /// The file's size, in bytes.
    /// </summary>
    [JsonPropertyName("size")]
    public long? Size { get; set; }

    /// <summary>
    /// The file's mime type.
    /// </summary>
    [JsonPropertyName("mime_type")]
    public string? MimeType { get; set; }

    /// <summary>
    /// The file's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The folder that the file belongs to.
    /// </summary>
    [JsonPropertyName("folder")]
    public OneOf<string, Folder>? Folder { get; set; }

    /// <summary>
    /// The Permission object is used to represent a user's or group's access to a File or Folder. Permissions are unexpanded by default. Use the query param `expand=permissions` to see more details under `GET /files`.
    /// </summary>
    [JsonPropertyName("permissions")]
    public OneOf<
        string,
        PermissionRequest,
        IEnumerable<OneOf<string, PermissionRequest>>
    >? Permissions { get; set; }

    /// <summary>
    /// The drive that the file belongs to.
    /// </summary>
    [JsonPropertyName("drive")]
    public OneOf<string, Drive>? Drive { get; set; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
