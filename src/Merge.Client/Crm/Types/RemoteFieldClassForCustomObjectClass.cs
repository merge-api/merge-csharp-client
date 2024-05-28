using System.Text.Json.Serialization;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class RemoteFieldClassForCustomObjectClass
{
    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; init; }

    [JsonPropertyName("remote_key_name")]
    public string? RemoteKeyName { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("is_required")]
    public bool? IsRequired { get; init; }

    [JsonPropertyName("field_type")]
    public FieldTypeEnum? FieldType { get; init; }

    [JsonPropertyName("field_format")]
    public FieldFormatEnum? FieldFormat { get; init; }

    [JsonPropertyName("field_choices")]
    public List<RemoteFieldClassForCustomObjectClassFieldChoicesItem>? FieldChoices { get; init; }

    [JsonPropertyName("item_schema")]
    public RemoteFieldClassForCustomObjectClassItemSchema? ItemSchema { get; init; }
}
