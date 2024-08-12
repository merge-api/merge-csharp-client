using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public record PaginatedEmploymentList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<Employment>? Results { get; set; }
}
