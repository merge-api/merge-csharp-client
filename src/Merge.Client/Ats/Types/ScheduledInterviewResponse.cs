using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public record ScheduledInterviewResponse
{
    [JsonPropertyName("model")]
    public required ScheduledInterview Model { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<WarningValidationProblem> Warnings { get; set; } =
        new List<WarningValidationProblem>();

    [JsonPropertyName("errors")]
    public IEnumerable<ErrorValidationProblem> Errors { get; set; } =
        new List<ErrorValidationProblem>();

    [JsonPropertyName("logs")]
    public IEnumerable<DebugModeLog>? Logs { get; set; }
}
