using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public record DebugModelLogSummary
{
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("method")]
    public required string Method { get; set; }

    [JsonPropertyName("status_code")]
    public required int StatusCode { get; set; }
}
