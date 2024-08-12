using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public record FieldMappingApiInstanceTargetField
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("is_organization_wide")]
    public required bool IsOrganizationWide { get; set; }
}
