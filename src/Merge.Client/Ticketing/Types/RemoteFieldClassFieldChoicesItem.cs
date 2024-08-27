using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ticketing;

public record RemoteFieldClassFieldChoicesItem
{
    [JsonPropertyName("value")]
    public object? Value { get; set; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
