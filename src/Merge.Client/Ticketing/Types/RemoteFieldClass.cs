using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

public class RemoteFieldClass
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; init; }

    [JsonPropertyName("remote_key_name")]
    public string? RemoteKeyName { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("is_custom")]
    public bool? IsCustom { get; init; }

    [JsonPropertyName("is_required")]
    public bool? IsRequired { get; init; }

    [JsonPropertyName("field_type")]
    public FieldTypeEnum? FieldType { get; init; }

    [JsonPropertyName("field_format")]
    public FieldFormatEnum? FieldFormat { get; init; }

    [JsonPropertyName("field_choices")]
    public IEnumerable<RemoteFieldClassFieldChoicesItem>? FieldChoices { get; init; }

    [JsonPropertyName("item_schema")]
    public ItemSchema? ItemSchema { get; init; }
}
