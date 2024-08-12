using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public record PaginatedNoteList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<Note>? Results { get; set; }
}
