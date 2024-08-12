using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public record PaginatedTaskList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<Task>? Results { get; set; }
}
