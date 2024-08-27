using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

public record RemoteKey
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
