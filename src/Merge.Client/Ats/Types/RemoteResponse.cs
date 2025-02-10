using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

public record RemoteResponse
{
    [JsonPropertyName("method")]
    public required string Method { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("status")]
    public required int Status { get; set; }

    [JsonPropertyName("response")]
    public required object Response { get; set; }

    [JsonPropertyName("response_headers")]
    public Dictionary<string, object?>? ResponseHeaders { get; set; }

    [JsonPropertyName("response_type")]
    public ResponseTypeEnum? ResponseType { get; set; }

    [JsonPropertyName("headers")]
    public Dictionary<string, object?>? Headers { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
