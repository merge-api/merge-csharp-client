using System.Text.Json.Serialization;
using Merge.Client.Crm;
using StringEnum;

namespace Merge.Client.Crm;

public class AssociationType
{
    [JsonPropertyName("source_object_class")]
    public Dictionary<string, object>? SourceObjectClass { get; init; }

    [JsonPropertyName("target_object_classes")]
    public List<AssociationSubType>? TargetObjectClasses { get; init; }

    [JsonPropertyName("remote_key_name")]
    public string? RemoteKeyName { get; init; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; init; }

    [JsonPropertyName("cardinality")]
    public StringEnum<CardinalityEnum>? Cardinality { get; init; }

    [JsonPropertyName("is_required")]
    public bool? IsRequired { get; init; }

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
}
