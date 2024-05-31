using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public class RemoteFieldClassForCustomObjectClassItemSchema
{
    [JsonPropertyName("item_type")]
    public string? ItemType { get; init; }

    [JsonPropertyName("item_format")]
    public string? ItemFormat { get; init; }

    [JsonPropertyName("item_choices")]
    public IEnumerable<string>? ItemChoices { get; init; }
}
