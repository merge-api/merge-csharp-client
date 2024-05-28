using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public class FieldMappingApiInstanceTargetField
{
    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("description")]
    public string Description { get; init; }

    [JsonPropertyName("is_organization_wide")]
    public bool IsOrganizationWide { get; init; }
}
