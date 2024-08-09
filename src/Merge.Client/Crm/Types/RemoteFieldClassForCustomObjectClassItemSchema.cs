using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public record RemoteFieldClassForCustomObjectClassItemSchema
{
    [JsonPropertyName("item_type")]
    public string? ItemType { get; set; }

    [JsonPropertyName("item_format")]
    public string? ItemFormat { get; set; }

    [JsonPropertyName("item_choices")]
    public IEnumerable<string>? ItemChoices { get; set; }
}
