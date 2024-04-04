using System.Text.Json.Serialization;

namespace Merge.Client.Crm;

public class CustomObjectRequest
{
    [JsonPropertyName("fields")]
    public Dictionary<string, object> Fields { get; init; }
}
