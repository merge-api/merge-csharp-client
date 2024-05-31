using System.Text.Json.Serialization;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class ExternalTargetFieldApiResponse
{
    [JsonPropertyName("Account")]
    public IEnumerable<ExternalTargetFieldApi>? Account { get; init; }

    [JsonPropertyName("Contact")]
    public IEnumerable<ExternalTargetFieldApi>? Contact { get; init; }

    [JsonPropertyName("Lead")]
    public IEnumerable<ExternalTargetFieldApi>? Lead { get; init; }

    [JsonPropertyName("Note")]
    public IEnumerable<ExternalTargetFieldApi>? Note { get; init; }

    [JsonPropertyName("Opportunity")]
    public IEnumerable<ExternalTargetFieldApi>? Opportunity { get; init; }

    [JsonPropertyName("Stage")]
    public IEnumerable<ExternalTargetFieldApi>? Stage { get; init; }

    [JsonPropertyName("User")]
    public IEnumerable<ExternalTargetFieldApi>? User { get; init; }

    [JsonPropertyName("Task")]
    public IEnumerable<ExternalTargetFieldApi>? Task { get; init; }

    [JsonPropertyName("Engagement")]
    public IEnumerable<ExternalTargetFieldApi>? Engagement { get; init; }
}
