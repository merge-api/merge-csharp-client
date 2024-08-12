using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public record WebhookReceiver
{
    [JsonPropertyName("event")]
    public required string Event { get; set; }

    [JsonPropertyName("is_active")]
    public required bool IsActive { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }
}
