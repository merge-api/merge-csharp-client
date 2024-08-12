using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public record RemoteFieldApiResponse
{
    [JsonPropertyName("Account")]
    public IEnumerable<RemoteFieldApi>? Account { get; set; }

    [JsonPropertyName("Contact")]
    public IEnumerable<RemoteFieldApi>? Contact { get; set; }

    [JsonPropertyName("Lead")]
    public IEnumerable<RemoteFieldApi>? Lead { get; set; }

    [JsonPropertyName("Note")]
    public IEnumerable<RemoteFieldApi>? Note { get; set; }

    [JsonPropertyName("Opportunity")]
    public IEnumerable<RemoteFieldApi>? Opportunity { get; set; }

    [JsonPropertyName("Stage")]
    public IEnumerable<RemoteFieldApi>? Stage { get; set; }

    [JsonPropertyName("User")]
    public IEnumerable<RemoteFieldApi>? User { get; set; }

    [JsonPropertyName("Task")]
    public IEnumerable<RemoteFieldApi>? Task { get; set; }

    [JsonPropertyName("Engagement")]
    public IEnumerable<RemoteFieldApi>? Engagement { get; set; }
}
