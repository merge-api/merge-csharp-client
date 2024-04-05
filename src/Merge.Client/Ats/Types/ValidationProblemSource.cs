using System.Text.Json.Serialization;

namespace Merge.Client.Ats;

public class ValidationProblemSource
{
    [JsonPropertyName("pointer")]
    public string Pointer { get; init; }
}
