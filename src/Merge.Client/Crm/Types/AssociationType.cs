using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

public record AssociationType
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
    /// The class of the source object (Custom Object or Common Model) for the association type.
    /// </summary>
    [JsonPropertyName("source_object_class")]
    public Dictionary<string, object?>? SourceObjectClass { get; set; }

    [JsonPropertyName("target_object_classes")]
    public IEnumerable<AssociationSubType>? TargetObjectClasses { get; set; }

    [JsonPropertyName("remote_key_name")]
    public string? RemoteKeyName { get; set; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("cardinality")]
    public CardinalityEnum? Cardinality { get; set; }

    [JsonPropertyName("is_required")]
    public bool? IsRequired { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
