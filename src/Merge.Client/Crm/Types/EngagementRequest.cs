using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Crm;
using OneOf;

#nullable enable

namespace Merge.Client.Crm;

public class EngagementRequest
{
    /// <summary>
    /// The engagement's owner.
    /// </summary>
    [JsonPropertyName("owner")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, User>>))]
    public OneOf<string, User>? Owner { get; init; }

    /// <summary>
    /// The engagement's content.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; init; }

    /// <summary>
    /// The engagement's subject.
    /// </summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; init; }

    /// <summary>
    /// The engagement's direction.
    ///
    /// - `INBOUND` - INBOUND
    /// - `OUTBOUND` - OUTBOUND
    /// </summary>
    [JsonPropertyName("direction")]
    public DirectionEnum? Direction { get; init; }

    /// <summary>
    /// The engagement type of the engagement.
    /// </summary>
    [JsonPropertyName("engagement_type")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, EngagementType>>))]
    public OneOf<string, EngagementType>? EngagementType { get; init; }

    /// <summary>
    /// The time at which the engagement started.
    /// </summary>
    [JsonPropertyName("start_time")]
    public DateTime? StartTime { get; init; }

    /// <summary>
    /// The time at which the engagement ended.
    /// </summary>
    [JsonPropertyName("end_time")]
    public DateTime? EndTime { get; init; }

    /// <summary>
    /// The account of the engagement.
    /// </summary>
    [JsonPropertyName("account")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Account>>))]
    public OneOf<string, Account>? Account { get; init; }

    [JsonPropertyName("contacts")]
    [JsonConverter(
        typeof(CollectionItemSerializer<
            OneOf<string, Contact>,
            OneOfSerializer<OneOf<string, Contact>>
        >)
    )]
    public IEnumerable<OneOf<string, Contact>>? Contacts { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }

    [JsonPropertyName("remote_fields")]
    public IEnumerable<RemoteFieldRequest>? RemoteFields { get; init; }
}
