using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public record ValidationProblemSource
{
    [JsonPropertyName("pointer")]
    public required string Pointer { get; set; }
}
