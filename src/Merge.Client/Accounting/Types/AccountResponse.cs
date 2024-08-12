using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public record AccountResponse
{
    [JsonPropertyName("model")]
    public required Account Model { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<WarningValidationProblem> Warnings { get; set; } =
        new List<WarningValidationProblem>();

    [JsonPropertyName("errors")]
    public IEnumerable<ErrorValidationProblem> Errors { get; set; } =
        new List<ErrorValidationProblem>();

    [JsonPropertyName("logs")]
    public IEnumerable<DebugModeLog>? Logs { get; set; }
}
