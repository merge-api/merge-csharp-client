using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

public record FieldMappingApiInstance
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("is_integration_wide")]
    public bool? IsIntegrationWide { get; set; }

    [JsonPropertyName("target_field")]
    public FieldMappingApiInstanceTargetField? TargetField { get; set; }

    [JsonPropertyName("remote_field")]
    public FieldMappingApiInstanceRemoteField? RemoteField { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
