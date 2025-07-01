using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[Serializable]
public record CommonModelScopesBodyRequest
{
    [JsonPropertyName("model_id")]
    public required string ModelId { get; set; }

    [JsonPropertyName("enabled_actions")]
    public IEnumerable<EnabledActionsEnum> EnabledActions { get; set; } =
        new List<EnabledActionsEnum>();

    [JsonPropertyName("disabled_fields")]
    public IEnumerable<string> DisabledFields { get; set; } = new List<string>();

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
