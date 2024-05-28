using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public class WebhookReceiver
{
    [JsonPropertyName("event")]
    public string Event { get; init; }

    [JsonPropertyName("is_active")]
    public bool IsActive { get; init; }

    [JsonPropertyName("key")]
    public string? Key { get; init; }
}
