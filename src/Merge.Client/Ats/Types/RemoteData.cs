using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

public record RemoteData
{
    /// <summary>
    /// The third-party API path that is being called.
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("data")]
    public object? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
