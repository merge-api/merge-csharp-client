using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

public record FieldMappingApiInstanceTargetField
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("is_organization_wide")]
    public required bool IsOrganizationWide { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
