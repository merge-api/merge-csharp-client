using System.Text.Json.Serialization;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class RemoteFieldApiResponse
{
    [JsonPropertyName("Account")]
    public IEnumerable<RemoteFieldApi>? Account { get; init; }

    [JsonPropertyName("Contact")]
    public IEnumerable<RemoteFieldApi>? Contact { get; init; }

    [JsonPropertyName("Lead")]
    public IEnumerable<RemoteFieldApi>? Lead { get; init; }

    [JsonPropertyName("Note")]
    public IEnumerable<RemoteFieldApi>? Note { get; init; }

    [JsonPropertyName("Opportunity")]
    public IEnumerable<RemoteFieldApi>? Opportunity { get; init; }

    [JsonPropertyName("Stage")]
    public IEnumerable<RemoteFieldApi>? Stage { get; init; }

    [JsonPropertyName("User")]
    public IEnumerable<RemoteFieldApi>? User { get; init; }

    [JsonPropertyName("Task")]
    public IEnumerable<RemoteFieldApi>? Task { get; init; }

    [JsonPropertyName("Engagement")]
    public IEnumerable<RemoteFieldApi>? Engagement { get; init; }
}
