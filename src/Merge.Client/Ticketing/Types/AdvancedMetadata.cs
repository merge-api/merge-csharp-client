using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

public record AdvancedMetadata
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("is_required")]
    public bool? IsRequired { get; set; }

    [JsonPropertyName("is_custom")]
    public bool? IsCustom { get; set; }

    [JsonPropertyName("field_choices")]
    public IEnumerable<object>? FieldChoices { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
