using System.Text.Json.Serialization;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class ItemSchema
{
    [JsonPropertyName("item_type")]
    public ItemTypeEnum? ItemType { get; init; }

    [JsonPropertyName("item_format")]
    public ItemFormatEnum? ItemFormat { get; init; }

    [JsonPropertyName("item_choices")]
    public IEnumerable<string>? ItemChoices { get; init; }
}
