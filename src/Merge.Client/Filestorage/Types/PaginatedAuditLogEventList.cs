using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public record PaginatedAuditLogEventList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<AuditLogEvent>? Results { get; set; }
}
