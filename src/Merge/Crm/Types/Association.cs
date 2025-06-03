using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;
using OneOf;

namespace Merge.Crm;

/// <summary>
/// # The Association Object
/// ### Description
/// The `Association` record refers to an instance of an Association Type.
/// ### Usage Example
/// TODO
/// </summary>
public record Association
{
    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("source_object")]
    public string? SourceObject { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("target_object")]
    public string? TargetObject { get; set; }

    /// <summary>
    /// The association type the association belongs to.
    /// </summary>
    [JsonPropertyName("association_type")]
    public OneOf<string, AssociationType>? AssociationType { get; set; }

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
