using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public record PaginatedPurchaseOrderList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<PurchaseOrder>? Results { get; set; }
}
