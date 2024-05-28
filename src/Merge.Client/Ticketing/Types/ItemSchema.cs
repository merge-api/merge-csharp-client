using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

public class ItemSchema
{
    [JsonPropertyName("item_type")]
    public ItemTypeEnum? ItemType { get; init; }

    [JsonPropertyName("item_format")]
    public ItemFormatEnum? ItemFormat { get; init; }

    [JsonPropertyName("item_choices")]
    public List<string>? ItemChoices { get; init; }
}
