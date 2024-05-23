using System.Text.Json.Serialization;

namespace Merge.Client.Crm;

public class WebhookReceiverRequest
{
    [JsonPropertyName("event")]
    public string Event { get; init; }

    [JsonPropertyName("is_active")]
    public bool IsActive { get; init; }

    [JsonPropertyName("key")]
    public string? Key { get; init; }
}
