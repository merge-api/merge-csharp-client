using System.Text.Json.Serialization;

namespace Merge.Client.Accounting;

public class ValidationProblemSource
{
    [JsonPropertyName("pointer")]
    public string Pointer { get; init; }
}
