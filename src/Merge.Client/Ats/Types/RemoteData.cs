using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

public record RemoteData
{
    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("data")]
    public object? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
