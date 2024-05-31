using System.Text.Json.Serialization;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class AssociationType
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
    /// The class of the source object (Custom Object or Common Model) for the association type.
    /// </summary>
    [JsonPropertyName("source_object_class")]
    public Dictionary<string, object>? SourceObjectClass { get; init; }

    [JsonPropertyName("target_object_classes")]
    public IEnumerable<AssociationSubType>? TargetObjectClasses { get; init; }

    [JsonPropertyName("remote_key_name")]
    public string? RemoteKeyName { get; init; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; init; }

    [JsonPropertyName("cardinality")]
    public CardinalityEnum? Cardinality { get; init; }

    [JsonPropertyName("is_required")]
    public bool? IsRequired { get; init; }
}
