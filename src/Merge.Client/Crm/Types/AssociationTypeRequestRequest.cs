using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[Serializable]
public record AssociationTypeRequestRequest
{
    [JsonPropertyName("source_object_class")]
    public required ObjectClassDescriptionRequest SourceObjectClass { get; set; }

    [JsonPropertyName("target_object_classes")]
    public IEnumerable<ObjectClassDescriptionRequest> TargetObjectClasses { get; set; } =
        new List<ObjectClassDescriptionRequest>();

    [JsonPropertyName("remote_key_name")]
    public required string RemoteKeyName { get; set; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("cardinality")]
    public CardinalityEnum? Cardinality { get; set; }

    [JsonPropertyName("is_required")]
    public bool? IsRequired { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
