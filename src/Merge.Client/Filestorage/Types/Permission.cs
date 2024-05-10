using System.Text.Json.Serialization;
using Merge.Client.Filestorage;
using OneOf;

namespace Merge.Client.Filestorage;

public class Permission
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// This is the datetime that this object was last updated by Merge
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    /// <summary>
    /// The user that is granted this permission.
    /// </summary>
    [JsonPropertyName("user")]
    public OneOf<string, User>? User { get; init; }

    /// <summary>
    /// The group that is granted this permission.
    /// </summary>
    [JsonPropertyName("group")]
    public OneOf<string, Group>? Group { get; init; }

    /// <summary>
    /// Denotes what type of people have access to the file.
    ///
    /// - `USER` - USER
    /// - `GROUP` - GROUP
    /// - `COMPANY` - COMPANY
    /// - `ANYONE` - ANYONE
    /// </summary>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; init; }

    /// <summary>
    /// The permissions that the user or group has for the File or Folder. It is possible for a user or group to have multiple roles, such as viewing & uploading. Possible values include: `READ`, `WRITE`, `OWNER`. In cases where there is no clear mapping, the original value passed through will be returned.
    /// </summary>
    [JsonPropertyName("roles")]
    public List<RolesEnum>? Roles { get; init; }
}
