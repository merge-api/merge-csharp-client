using System.Text.Json.Serialization;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class ExternalTargetFieldApiResponse
{
    [JsonPropertyName("Account")]
    public List<ExternalTargetFieldApi>? Account { get; init; }

    [JsonPropertyName("Contact")]
    public List<ExternalTargetFieldApi>? Contact { get; init; }

    [JsonPropertyName("Lead")]
    public List<ExternalTargetFieldApi>? Lead { get; init; }

    [JsonPropertyName("Note")]
    public List<ExternalTargetFieldApi>? Note { get; init; }

    [JsonPropertyName("Opportunity")]
    public List<ExternalTargetFieldApi>? Opportunity { get; init; }

    [JsonPropertyName("Stage")]
    public List<ExternalTargetFieldApi>? Stage { get; init; }

    [JsonPropertyName("User")]
    public List<ExternalTargetFieldApi>? User { get; init; }

    [JsonPropertyName("Task")]
    public List<ExternalTargetFieldApi>? Task { get; init; }

    [JsonPropertyName("Engagement")]
    public List<ExternalTargetFieldApi>? Engagement { get; init; }
}
