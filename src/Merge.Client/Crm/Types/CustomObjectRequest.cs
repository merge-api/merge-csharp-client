using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public record CustomObjectRequest
{
    [JsonPropertyName("fields")]
    public Dictionary<string, object?> Fields { get; set; } = new Dictionary<string, object?>();
}
