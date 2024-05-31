using System.Text.Json.Serialization;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class FieldMappingApiInstanceResponse
{
    [JsonPropertyName("Account")]
    public IEnumerable<FieldMappingApiInstance>? Account { get; init; }

    [JsonPropertyName("Contact")]
    public IEnumerable<FieldMappingApiInstance>? Contact { get; init; }

    [JsonPropertyName("Lead")]
    public IEnumerable<FieldMappingApiInstance>? Lead { get; init; }

    [JsonPropertyName("Note")]
    public IEnumerable<FieldMappingApiInstance>? Note { get; init; }

    [JsonPropertyName("Opportunity")]
    public IEnumerable<FieldMappingApiInstance>? Opportunity { get; init; }

    [JsonPropertyName("Stage")]
    public IEnumerable<FieldMappingApiInstance>? Stage { get; init; }

    [JsonPropertyName("User")]
    public IEnumerable<FieldMappingApiInstance>? User { get; init; }

    [JsonPropertyName("Task")]
    public IEnumerable<FieldMappingApiInstance>? Task { get; init; }

    [JsonPropertyName("Engagement")]
    public IEnumerable<FieldMappingApiInstance>? Engagement { get; init; }
}
