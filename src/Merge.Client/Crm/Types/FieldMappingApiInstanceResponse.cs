using System.Text.Json.Serialization;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class FieldMappingApiInstanceResponse
{
    [JsonPropertyName("Account")]
    public List<FieldMappingApiInstance>? Account { get; init; }

    [JsonPropertyName("Contact")]
    public List<FieldMappingApiInstance>? Contact { get; init; }

    [JsonPropertyName("Lead")]
    public List<FieldMappingApiInstance>? Lead { get; init; }

    [JsonPropertyName("Note")]
    public List<FieldMappingApiInstance>? Note { get; init; }

    [JsonPropertyName("Opportunity")]
    public List<FieldMappingApiInstance>? Opportunity { get; init; }

    [JsonPropertyName("Stage")]
    public List<FieldMappingApiInstance>? Stage { get; init; }

    [JsonPropertyName("User")]
    public List<FieldMappingApiInstance>? User { get; init; }

    [JsonPropertyName("Task")]
    public List<FieldMappingApiInstance>? Task { get; init; }

    [JsonPropertyName("Engagement")]
    public List<FieldMappingApiInstance>? Engagement { get; init; }
}
