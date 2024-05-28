using System.Text.Json.Serialization;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class RemoteFieldApiResponse
{
    [JsonPropertyName("Account")]
    public List<RemoteFieldApi>? Account { get; init; }

    [JsonPropertyName("Contact")]
    public List<RemoteFieldApi>? Contact { get; init; }

    [JsonPropertyName("Lead")]
    public List<RemoteFieldApi>? Lead { get; init; }

    [JsonPropertyName("Note")]
    public List<RemoteFieldApi>? Note { get; init; }

    [JsonPropertyName("Opportunity")]
    public List<RemoteFieldApi>? Opportunity { get; init; }

    [JsonPropertyName("Stage")]
    public List<RemoteFieldApi>? Stage { get; init; }

    [JsonPropertyName("User")]
    public List<RemoteFieldApi>? User { get; init; }

    [JsonPropertyName("Task")]
    public List<RemoteFieldApi>? Task { get; init; }

    [JsonPropertyName("Engagement")]
    public List<RemoteFieldApi>? Engagement { get; init; }
}
