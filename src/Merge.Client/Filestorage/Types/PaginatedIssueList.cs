using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public record PaginatedIssueList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<Issue>? Results { get; set; }
}
