using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public class AdvancedMetadata
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("is_required")]
    public bool? IsRequired { get; init; }

    [JsonPropertyName("is_custom")]
    public bool? IsCustom { get; init; }

    [JsonPropertyName("field_choices")]
    public IEnumerable<object>? FieldChoices { get; init; }
}
