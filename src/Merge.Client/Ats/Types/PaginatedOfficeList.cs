using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public record PaginatedOfficeList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<Office>? Results { get; set; }
}
