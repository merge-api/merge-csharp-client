using System.Text.Json.Serialization;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

public class PaginatedIncomeStatementList
{
    [JsonPropertyName("next")]
    public string? Next { get; init; }

    [JsonPropertyName("previous")]
    public string? Previous { get; init; }

    [JsonPropertyName("results")]
    public IEnumerable<IncomeStatement>? Results { get; init; }
}
