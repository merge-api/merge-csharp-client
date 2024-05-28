using System.Text.Json.Serialization;
using Merge.Client.Ats;

#nullable enable

namespace Merge.Client.Ats;

public class RemoteResponse
{
    [JsonPropertyName("method")]
    public string Method { get; init; }

    [JsonPropertyName("path")]
    public string Path { get; init; }

    [JsonPropertyName("status")]
    public int Status { get; init; }

    [JsonPropertyName("response")]
    public object Response { get; init; }

    [JsonPropertyName("response_headers")]
    public Dictionary<string, object>? ResponseHeaders { get; init; }

    [JsonPropertyName("response_type")]
    public ResponseTypeEnum? ResponseType { get; init; }

    [JsonPropertyName("headers")]
    public Dictionary<string, object>? Headers { get; init; }
}
