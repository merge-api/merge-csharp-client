using System.Text.Json.Serialization;

namespace Merge.Client.Filestorage;

public class User
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
    /// The user's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The user's email address. This is typically used to identify a user across linked accounts.
    /// </summary>
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// Whether the user is the one who linked this account.
    /// </summary>
    [JsonPropertyName("is_me")]
    public bool? IsMe { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public List<Dictionary<string, object>?>? RemoteData { get; init; }
}
