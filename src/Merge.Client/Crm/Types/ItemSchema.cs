using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public record ItemSchema
{
    [JsonPropertyName("item_type")]
    public ItemTypeEnum? ItemType { get; set; }

    [JsonPropertyName("item_format")]
    public ItemFormatEnum? ItemFormat { get; set; }

    [JsonPropertyName("item_choices")]
    public IEnumerable<string>? ItemChoices { get; set; }
}
