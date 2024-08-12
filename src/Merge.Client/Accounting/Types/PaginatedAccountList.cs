using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public record PaginatedAccountList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<Account>? Results { get; set; }
}
