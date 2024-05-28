using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public class RemoteKey
{
    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("key")]
    public string Key { get; init; }
}
