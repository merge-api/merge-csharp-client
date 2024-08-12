using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public record ModelPermissionDeserializerRequest
{
    [JsonPropertyName("is_enabled")]
    public bool? IsEnabled { get; set; }
}
