using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public record WarningValidationProblem
{
    [JsonPropertyName("source")]
    public ValidationProblemSource? Source { get; set; }

    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("detail")]
    public required string Detail { get; set; }

    [JsonPropertyName("problem_type")]
    public required string ProblemType { get; set; }
}
