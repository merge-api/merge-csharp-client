using System.Text.Json.Serialization;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class ItemSchema
{
    [JsonPropertyName("item_type")]
    public ItemTypeEnum? ItemType { get; init; }

    [JsonPropertyName("item_format")]
    public ItemFormatEnum? ItemFormat { get; init; }

    [JsonPropertyName("item_choices")]
    public List<string>? ItemChoices { get; init; }
}
