using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public record FieldMappingApiInstanceResponse
{
    [JsonPropertyName("Account")]
    public IEnumerable<FieldMappingApiInstance>? Account { get; set; }

    [JsonPropertyName("Contact")]
    public IEnumerable<FieldMappingApiInstance>? Contact { get; set; }

    [JsonPropertyName("Lead")]
    public IEnumerable<FieldMappingApiInstance>? Lead { get; set; }

    [JsonPropertyName("Note")]
    public IEnumerable<FieldMappingApiInstance>? Note { get; set; }

    [JsonPropertyName("Opportunity")]
    public IEnumerable<FieldMappingApiInstance>? Opportunity { get; set; }

    [JsonPropertyName("Stage")]
    public IEnumerable<FieldMappingApiInstance>? Stage { get; set; }

    [JsonPropertyName("User")]
    public IEnumerable<FieldMappingApiInstance>? User { get; set; }

    [JsonPropertyName("Task")]
    public IEnumerable<FieldMappingApiInstance>? Task { get; set; }

    [JsonPropertyName("Engagement")]
    public IEnumerable<FieldMappingApiInstance>? Engagement { get; set; }
}
