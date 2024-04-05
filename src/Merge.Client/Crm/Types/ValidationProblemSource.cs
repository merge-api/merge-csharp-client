using System.Text.Json.Serialization;

namespace Merge.Client.Crm;

public class ValidationProblemSource
{
    [JsonPropertyName("pointer")]
    public string Pointer { get; init; }
}
