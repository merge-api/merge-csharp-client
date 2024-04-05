using System.Text.Json.Serialization;

namespace Merge.Client.Crm;

public class RemoteFieldClassFieldChoicesItem
{
    [JsonPropertyName("value")]
    public object? Value { get; init; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; init; }
}
