using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

public record RemoteFieldClassForCustomObjectClassFieldChoicesItem
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
