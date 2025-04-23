using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

public record ExternalTargetFieldApi
{
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("is_mapped")]
    public string? IsMapped { get; set; }

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
