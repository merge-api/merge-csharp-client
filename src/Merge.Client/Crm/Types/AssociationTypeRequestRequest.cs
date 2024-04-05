using System.Text.Json.Serialization;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class AssociationTypeRequestRequest
{
    [JsonPropertyName("source_object_class")]
    public ObjectClassDescriptionRequest SourceObjectClass { get; init; }

    [JsonPropertyName("target_object_classes")]
    public List<ObjectClassDescriptionRequest> TargetObjectClasses { get; init; }

    [JsonPropertyName("remote_key_name")]
    public string RemoteKeyName { get; init; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; init; }

    [JsonPropertyName("cardinality")]
    public CardinalityEnum? Cardinality { get; init; }

    [JsonPropertyName("is_required")]
    public bool? IsRequired { get; init; }
}
