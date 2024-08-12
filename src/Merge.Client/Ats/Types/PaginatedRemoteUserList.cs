using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public record PaginatedRemoteUserList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<RemoteUser>? Results { get; set; }
}
