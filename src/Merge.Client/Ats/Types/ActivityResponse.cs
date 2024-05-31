using System.Text.Json.Serialization;
using Merge.Client.Ats;

#nullable enable

namespace Merge.Client.Ats;

public class ActivityResponse
{
    [JsonPropertyName("model")]
    public Activity Model { get; init; }

    [JsonPropertyName("warnings")]
    public IEnumerable<WarningValidationProblem> Warnings { get; init; }

    [JsonPropertyName("errors")]
    public IEnumerable<ErrorValidationProblem> Errors { get; init; }

    [JsonPropertyName("logs")]
    public IEnumerable<DebugModeLog>? Logs { get; init; }
}
