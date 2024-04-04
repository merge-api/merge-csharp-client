using System.Text.Json.Serialization;
using StringEnum;
using Merge.Client.Hris;

namespace Merge.Client.Hris;

public class CommonModelScopesBodyRequest
{
    [JsonPropertyName("model_id")]
    public string ModelId { get; init; }

    [JsonPropertyName("enabled_actions")]
    public List<StringEnum<EnabledActionsEnum>> EnabledActions { get; init; }

    [JsonPropertyName("disabled_fields")]
    public List<string> DisabledFields { get; init; }
}
