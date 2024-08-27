using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

public record CommonModelScopesBodyRequest
{
    [JsonPropertyName("model_id")]
    public required string ModelId { get; set; }

    [JsonPropertyName("enabled_actions")]
    public IEnumerable<EnabledActionsEnum> EnabledActions { get; set; } =
        new List<EnabledActionsEnum>();

    [JsonPropertyName("disabled_fields")]
    public IEnumerable<string> DisabledFields { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
