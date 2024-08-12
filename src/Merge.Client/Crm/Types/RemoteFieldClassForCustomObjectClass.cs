using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public record RemoteFieldClassForCustomObjectClass
{
    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("remote_key_name")]
    public string? RemoteKeyName { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("is_required")]
    public bool? IsRequired { get; set; }

    [JsonPropertyName("field_type")]
    public FieldTypeEnum? FieldType { get; set; }

    [JsonPropertyName("field_format")]
    public FieldFormatEnum? FieldFormat { get; set; }

    [JsonPropertyName("field_choices")]
    public IEnumerable<RemoteFieldClassForCustomObjectClassFieldChoicesItem>? FieldChoices { get; set; }

    [JsonPropertyName("item_schema")]
    public RemoteFieldClassForCustomObjectClassItemSchema? ItemSchema { get; set; }
}
