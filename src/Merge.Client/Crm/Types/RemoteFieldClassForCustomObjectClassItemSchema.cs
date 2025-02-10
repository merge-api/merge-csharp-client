using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

public record RemoteFieldClassForCustomObjectClassItemSchema
{
    [JsonPropertyName("item_type")]
    public string? ItemType { get; set; }

    [JsonPropertyName("item_format")]
    public string? ItemFormat { get; set; }

    [JsonPropertyName("item_choices")]
    public IEnumerable<string>? ItemChoices { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
