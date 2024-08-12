using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public record ExternalTargetFieldApi
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("is_mapped")]
    public string? IsMapped { get; set; }
}
