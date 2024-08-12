using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public record CandidateResponse
{
    [JsonPropertyName("model")]
    public required Candidate Model { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<WarningValidationProblem> Warnings { get; set; } =
        new List<WarningValidationProblem>();

    [JsonPropertyName("errors")]
    public IEnumerable<ErrorValidationProblem> Errors { get; set; } =
        new List<ErrorValidationProblem>();

    [JsonPropertyName("logs")]
    public IEnumerable<DebugModeLog>? Logs { get; set; }
}
