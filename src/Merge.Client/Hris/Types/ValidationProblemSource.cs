using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public class ValidationProblemSource
{
    [JsonPropertyName("pointer")]
    public string Pointer { get; init; }
}
