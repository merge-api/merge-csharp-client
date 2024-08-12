using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public record RemoteFieldClassForCustomObjectClassFieldChoicesItem
{
    [JsonPropertyName("value")]
    public object? Value { get; set; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }
}
