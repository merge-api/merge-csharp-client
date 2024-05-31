using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Ticketing;
using OneOf;

#nullable enable

namespace Merge.Client.Ticketing;

public class User
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
    /// The user's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The user's email address.
    /// </summary>
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// Whether or not the user is active.
    /// </summary>
    [JsonPropertyName("is_active")]
    public bool? IsActive { get; init; }

    [JsonPropertyName("teams")]
    [JsonConverter(
        typeof(CollectionItemSerializer<OneOf<string, Team>, OneOfSerializer<OneOf<string, Team>>>)
    )]
    public IEnumerable<OneOf<string, Team>>? Teams { get; init; }

    [JsonPropertyName("roles")]
    [JsonConverter(
        typeof(CollectionItemSerializer<OneOf<string, Role>, OneOfSerializer<OneOf<string, Role>>>)
    )]
    public IEnumerable<OneOf<string, Role>>? Roles { get; init; }

    /// <summary>
    /// The user's avatar picture.
    /// </summary>
    [JsonPropertyName("avatar")]
    public string? Avatar { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; init; }
}
