using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public class FieldPermissionDeserializerRequest
{
    [JsonPropertyName("enabled")]
    public List<object>? Enabled { get; init; }

    [JsonPropertyName("disabled")]
    public List<object>? Disabled { get; init; }
}
