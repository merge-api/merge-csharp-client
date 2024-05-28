using System.Text.Json.Serialization;
using Merge.Client.Ats;

#nullable enable

namespace Merge.Client.Ats;

public class PaginatedJobList
{
    [JsonPropertyName("next")]
    public string? Next { get; init; }

    [JsonPropertyName("previous")]
    public string? Previous { get; init; }

    [JsonPropertyName("results")]
    public List<Job>? Results { get; init; }
}
