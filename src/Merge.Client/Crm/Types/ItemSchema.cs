using System.Text.Json.Serialization;
using Merge.Client.Core;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
