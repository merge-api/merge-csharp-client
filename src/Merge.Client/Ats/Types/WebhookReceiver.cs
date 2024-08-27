using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

public record WebhookReceiver
{
    [JsonPropertyName("event")]
    public required string Event { get; set; }

    [JsonPropertyName("is_active")]
    public required bool IsActive { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
