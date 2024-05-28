using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public class ValidationProblemSource
{
    [JsonPropertyName("pointer")]
    public string Pointer { get; init; }
}
