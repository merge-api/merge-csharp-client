using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public record PaginatedTicketList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<Ticket>? Results { get; set; }
}
