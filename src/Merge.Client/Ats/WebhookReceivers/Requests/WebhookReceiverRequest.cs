using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[Serializable]
public record WebhookReceiverRequest
{
    [JsonPropertyName("event")]
    public required string Event { get; set; }

    [JsonPropertyName("is_active")]
    public required bool IsActive { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
