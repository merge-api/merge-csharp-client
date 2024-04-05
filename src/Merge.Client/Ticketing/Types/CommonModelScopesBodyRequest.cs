using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

namespace Merge.Client.Ticketing;

public class CommonModelScopesBodyRequest
{
    [JsonPropertyName("model_id")]
    public string ModelId { get; init; }

    [JsonPropertyName("enabled_actions")]
    public List<EnabledActionsEnum> EnabledActions { get; init; }

    [JsonPropertyName("disabled_fields")]
    public List<string> DisabledFields { get; init; }
}
