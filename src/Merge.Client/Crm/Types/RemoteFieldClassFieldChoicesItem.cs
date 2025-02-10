using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

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
