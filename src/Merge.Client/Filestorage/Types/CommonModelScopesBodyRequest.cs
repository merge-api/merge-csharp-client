using System.Text.Json.Serialization;
using Merge.Client.Filestorage;

#nullable enable

namespace Merge.Client.Filestorage;

public class CommonModelScopesBodyRequest
{
    [JsonPropertyName("model_id")]
    public string ModelId { get; init; }

    [JsonPropertyName("enabled_actions")]
    public IEnumerable<EnabledActionsEnum> EnabledActions { get; init; }

    [JsonPropertyName("disabled_fields")]
    public IEnumerable<string> DisabledFields { get; init; }
}
