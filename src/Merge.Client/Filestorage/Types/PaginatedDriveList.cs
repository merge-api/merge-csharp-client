using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public record PaginatedDriveList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<Drive>? Results { get; set; }
}
