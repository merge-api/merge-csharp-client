using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Filestorage;

public record Permission
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
    /// The user that is granted this permission.
    /// </summary>
    [JsonPropertyName("user")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, User>>))]
    public OneOf<string, User>? User { get; set; }

    /// <summary>
    /// The group that is granted this permission.
    /// </summary>
    [JsonPropertyName("group")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Group>>))]
    public OneOf<string, Group>? Group { get; set; }

    /// <summary>
    /// Denotes what type of people have access to the file.
    ///
    /// - `USER` - USER
    /// - `GROUP` - GROUP
    /// - `COMPANY` - COMPANY
    /// - `ANYONE` - ANYONE
    /// </summary>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// The permissions that the user or group has for the File or Folder. It is possible for a user or group to have multiple roles, such as viewing & uploading. Possible values include: `READ`, `WRITE`, `OWNER`. In cases where there is no clear mapping, the original value passed through will be returned.
    /// </summary>
    [JsonPropertyName("roles")]
    public IEnumerable<RolesEnum>? Roles { get; set; }
}
