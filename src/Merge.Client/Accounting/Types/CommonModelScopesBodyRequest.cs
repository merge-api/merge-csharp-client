using System.Text.Json.Serialization;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

public class CommonModelScopesBodyRequest
{
    [JsonPropertyName("model_id")]
    public string ModelId { get; init; }

    [JsonPropertyName("enabled_actions")]
    public List<EnabledActionsEnum> EnabledActions { get; init; }

    [JsonPropertyName("disabled_fields")]
    public List<string> DisabledFields { get; init; }
}
