using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public class ExternalTargetFieldApi
{
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("is_mapped")]
    public string? IsMapped { get; init; }
}
