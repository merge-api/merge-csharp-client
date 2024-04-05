using System.Text.Json.Serialization;

namespace Merge.Client.Ats;

public class DebugModelLogSummary
{
    [JsonPropertyName("url")]
    public string Url { get; init; }

    [JsonPropertyName("method")]
    public string Method { get; init; }

    [JsonPropertyName("status_code")]
    public int StatusCode { get; init; }
}
