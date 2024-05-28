using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public class RemoteData
{
    [JsonPropertyName("path")]
    public string Path { get; init; }

    [JsonPropertyName("data")]
    public object? Data { get; init; }
}
