using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public record PaginatedFileList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<File>? Results { get; set; }
}
