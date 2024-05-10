using System.Text.Json.Serialization;

namespace Merge.Client.Filestorage;

public class FieldMappingApiInstanceTargetField
{
    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("description")]
    public string Description { get; init; }

    [JsonPropertyName("is_organization_wide")]
    public bool IsOrganizationWide { get; init; }
}
