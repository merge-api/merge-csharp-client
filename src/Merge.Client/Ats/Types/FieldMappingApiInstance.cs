using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ats;

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
}
