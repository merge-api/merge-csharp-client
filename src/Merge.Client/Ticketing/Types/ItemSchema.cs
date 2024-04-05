using System.Text.Json.Serialization;
using StringEnum;
using Merge.Client.Ticketing;

namespace Merge.Client.Ticketing;

public class ItemSchema
{
    [JsonPropertyName("item_type")]
    public StringEnum<ItemTypeEnum>? ItemType { get; init; }

    [JsonPropertyName("item_format")]
    public StringEnum<ItemFormatEnum>? ItemFormat { get; init; }

    [JsonPropertyName("item_choices")]
    public List<string>? ItemChoices { get; init; }
}
