using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Filestorage;

public record PermissionRequest
{
    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; set; }

    /// <summary>
    /// The user that is granted this permission. This will only be populated if the type is `USER`.
    /// </summary>
    [JsonPropertyName("user")]
    public OneOf<string, User>? User { get; set; }

    /// <summary>
    /// The group that is granted this permission. This will only be populated if the type is `GROUP`.
    /// </summary>
    [JsonPropertyName("group")]
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

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
