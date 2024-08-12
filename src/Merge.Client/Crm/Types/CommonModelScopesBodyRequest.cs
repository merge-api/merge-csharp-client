using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public record CommonModelScopesBodyRequest
{
    [JsonPropertyName("model_id")]
    public required string ModelId { get; set; }

    [JsonPropertyName("enabled_actions")]
    public IEnumerable<EnabledActionsEnum> EnabledActions { get; set; } =
        new List<EnabledActionsEnum>();

    [JsonPropertyName("disabled_fields")]
    public IEnumerable<string> DisabledFields { get; set; } = new List<string>();
}
