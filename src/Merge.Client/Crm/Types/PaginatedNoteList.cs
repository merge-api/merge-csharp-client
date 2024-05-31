using System.Text.Json.Serialization;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class PaginatedNoteList
{
    [JsonPropertyName("next")]
    public string? Next { get; init; }

    [JsonPropertyName("previous")]
    public string? Previous { get; init; }

    [JsonPropertyName("results")]
    public IEnumerable<Note>? Results { get; init; }
}
