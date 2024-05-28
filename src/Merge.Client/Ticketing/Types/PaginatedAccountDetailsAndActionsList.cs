using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

public class PaginatedAccountDetailsAndActionsList
{
    [JsonPropertyName("next")]
    public string? Next { get; init; }

    [JsonPropertyName("previous")]
    public string? Previous { get; init; }

    [JsonPropertyName("results")]
    public List<AccountDetailsAndActions>? Results { get; init; }
}
