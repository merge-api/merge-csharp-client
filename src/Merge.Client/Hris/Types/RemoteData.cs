using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public record RemoteData
{
    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("data")]
    public object? Data { get; set; }
}
