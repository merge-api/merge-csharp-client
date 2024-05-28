using System.Text.Json.Serialization;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

public class PaginatedPaymentList
{
    [JsonPropertyName("next")]
    public string? Next { get; init; }

    [JsonPropertyName("previous")]
    public string? Previous { get; init; }

    [JsonPropertyName("results")]
    public List<Payment>? Results { get; init; }
}
