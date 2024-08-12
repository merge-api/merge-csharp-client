using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public record PaginatedCustomObjectClassList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<CustomObjectClass>? Results { get; set; }
}
