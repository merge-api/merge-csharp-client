using System.Text.Json.Serialization;
using Merge.Client.Ats;

#nullable enable

namespace Merge.Client.Ats;

public class ScheduledInterviewResponse
{
    [JsonPropertyName("model")]
    public ScheduledInterview Model { get; init; }

    [JsonPropertyName("warnings")]
    public List<WarningValidationProblem> Warnings { get; init; }

    [JsonPropertyName("errors")]
    public List<ErrorValidationProblem> Errors { get; init; }

    [JsonPropertyName("logs")]
    public List<DebugModeLog>? Logs { get; init; }
}
