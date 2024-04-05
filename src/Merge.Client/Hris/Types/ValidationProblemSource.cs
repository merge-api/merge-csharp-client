using System.Text.Json.Serialization;

namespace Merge.Client.Hris;

public class ValidationProblemSource
{
    [JsonPropertyName("pointer")]
    public string Pointer { get; init; }
}
