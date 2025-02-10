using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

public record ExternalTargetFieldApiResponse
{
    [JsonPropertyName("Account")]
    public IEnumerable<ExternalTargetFieldApi>? Account { get; set; }

    [JsonPropertyName("Contact")]
    public IEnumerable<ExternalTargetFieldApi>? Contact { get; set; }

    [JsonPropertyName("Lead")]
    public IEnumerable<ExternalTargetFieldApi>? Lead { get; set; }

    [JsonPropertyName("Note")]
    public IEnumerable<ExternalTargetFieldApi>? Note { get; set; }

    [JsonPropertyName("Opportunity")]
    public IEnumerable<ExternalTargetFieldApi>? Opportunity { get; set; }

    [JsonPropertyName("Stage")]
    public IEnumerable<ExternalTargetFieldApi>? Stage { get; set; }

    [JsonPropertyName("User")]
    public IEnumerable<ExternalTargetFieldApi>? User { get; set; }

    [JsonPropertyName("Task")]
    public IEnumerable<ExternalTargetFieldApi>? Task { get; set; }

    [JsonPropertyName("Engagement")]
    public IEnumerable<ExternalTargetFieldApi>? Engagement { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
