using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Crm;

/// <summary>
/// # The Custom Object Class Object
/// ### Description
/// The `Custom Object Class` object is used to represent a Custom Object Schema in the remote system.
/// ### Usage Example
/// TODO
/// </summary>
public record CustomObjectClass
{
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// The custom object class's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The custom object class's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The custom object class's singular and plural labels.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("labels")]
    public Dictionary<string, string?>? Labels { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("fields")]
    public IEnumerable<RemoteFieldClassForCustomObjectClass>? Fields { get; set; }

    /// <summary>
    /// The types of associations with other models that the custom object class can have.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("association_types")]
    public IEnumerable<object>? AssociationTypes { get; set; }

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
