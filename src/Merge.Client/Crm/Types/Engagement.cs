using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Crm;

public record Engagement
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
    /// The engagement's owner.
    /// </summary>
    [JsonPropertyName("owner")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, User>>))]
    public OneOf<string, User>? Owner { get; set; }

    /// <summary>
    /// The engagement's content.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// The engagement's subject.
    /// </summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>
    /// The engagement's direction.
    ///
    /// - `INBOUND` - INBOUND
    /// - `OUTBOUND` - OUTBOUND
    /// </summary>
    [JsonPropertyName("direction")]
    public DirectionEnum? Direction { get; set; }

    /// <summary>
    /// The engagement type of the engagement.
    /// </summary>
    [JsonPropertyName("engagement_type")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, EngagementType>>))]
    public OneOf<string, EngagementType>? EngagementType { get; set; }

    /// <summary>
    /// The time at which the engagement started.
    /// </summary>
    [JsonPropertyName("start_time")]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// The time at which the engagement ended.
    /// </summary>
    [JsonPropertyName("end_time")]
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// The account of the engagement.
    /// </summary>
    [JsonPropertyName("account")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Account>>))]
    public OneOf<string, Account>? Account { get; set; }

    [JsonPropertyName("contacts")]
    [JsonConverter(
        typeof(CollectionItemSerializer<
            OneOf<string, Contact>,
            OneOfSerializer<OneOf<string, Contact>>
        >)
    )]
    public IEnumerable<OneOf<string, Contact>>? Contacts { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

    [JsonPropertyName("remote_fields")]
    public IEnumerable<RemoteField>? RemoteFields { get; set; }
}
