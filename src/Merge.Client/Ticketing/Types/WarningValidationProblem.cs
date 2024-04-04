using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

namespace Merge.Client.Ticketing;

public class WarningValidationProblem
{
    [JsonPropertyName("source")]
    public ValidationProblemSource? Source { get; init; }

    [JsonPropertyName("title")]
    public string Title { get; init; }

    [JsonPropertyName("detail")]
    public string Detail { get; init; }

    [JsonPropertyName("problem_type")]
    public string ProblemType { get; init; }
}
