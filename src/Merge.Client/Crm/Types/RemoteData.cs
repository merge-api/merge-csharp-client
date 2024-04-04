using System.Text.Json.Serialization;

namespace Merge.Client.Crm;

public class RemoteData
{
    [JsonPropertyName("path")]
    public string Path { get; init; }

    [JsonPropertyName("data")]
    public object? Data { get; init; }
}
