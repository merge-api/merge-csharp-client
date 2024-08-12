using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public record PaginatedProjectList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<Project>? Results { get; set; }
}
