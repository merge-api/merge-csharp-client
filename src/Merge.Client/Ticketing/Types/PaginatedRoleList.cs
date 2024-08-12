using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public record PaginatedRoleList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<Role>? Results { get; set; }
}
