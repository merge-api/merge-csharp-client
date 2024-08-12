using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public record PaginatedTrackingCategoryList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<TrackingCategory>? Results { get; set; }
}
