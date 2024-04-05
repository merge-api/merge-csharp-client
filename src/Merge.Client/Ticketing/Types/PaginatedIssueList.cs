using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

namespace Merge.Client.Ticketing;

public class PaginatedIssueList
{
    [JsonPropertyName("next")]
    public string? Next { get; init; }

    [JsonPropertyName("previous")]
    public string? Previous { get; init; }

    [JsonPropertyName("results")]
    public List<Issue>? Results { get; init; }
}
