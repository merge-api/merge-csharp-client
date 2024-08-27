using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ticketing;

public record RemoteFieldClass
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("remote_key_name")]
    public string? RemoteKeyName { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("is_custom")]
    public bool? IsCustom { get; set; }

    [JsonPropertyName("is_required")]
    public bool? IsRequired { get; set; }

    [JsonPropertyName("field_type")]
    public FieldTypeEnum? FieldType { get; set; }

    [JsonPropertyName("field_format")]
    public FieldFormatEnum? FieldFormat { get; set; }

    [JsonPropertyName("field_choices")]
    public IEnumerable<RemoteFieldClassFieldChoicesItem>? FieldChoices { get; set; }

    [JsonPropertyName("item_schema")]
    public ItemSchema? ItemSchema { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
