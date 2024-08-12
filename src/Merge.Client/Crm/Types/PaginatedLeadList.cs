using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public record PaginatedLeadList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<Lead>? Results { get; set; }
}
