using System.Text.Json.Serialization;
using Merge.Client.Ats;

#nullable enable

namespace Merge.Client.Ats;

public class RemoteUser
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    /// <summary>
    /// The user's first name.
    /// </summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; init; }

    /// <summary>
    /// The user's last name.
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; init; }

    /// <summary>
    /// The user's email.
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    /// <summary>
    /// Whether the user's account had been disabled.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; init; }

    /// <summary>
    /// When the third party's user was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; init; }

    /// <summary>
    /// The user's role.
    ///
    /// - `SUPER_ADMIN` - SUPER_ADMIN
    /// - `ADMIN` - ADMIN
    /// - `TEAM_MEMBER` - TEAM_MEMBER
    /// - `LIMITED_TEAM_MEMBER` - LIMITED_TEAM_MEMBER
    /// - `INTERVIEWER` - INTERVIEWER
    /// </summary>
    [JsonPropertyName("access_role")]
    public AccessRoleEnum? AccessRole { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public List<RemoteData>? RemoteData { get; init; }
}
