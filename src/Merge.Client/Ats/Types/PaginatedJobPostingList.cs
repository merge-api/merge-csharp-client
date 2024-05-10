using System.Text.Json.Serialization;
using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class PaginatedJobPostingList
{
    [JsonPropertyName("next")]
    public string? Next { get; init; }

    [JsonPropertyName("previous")]
    public string? Previous { get; init; }

    [JsonPropertyName("results")]
    public List<JobPosting>? Results { get; init; }
}
