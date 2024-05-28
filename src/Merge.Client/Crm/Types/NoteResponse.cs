using System.Text.Json.Serialization;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class NoteResponse
{
    [JsonPropertyName("model")]
    public Note Model { get; init; }

    [JsonPropertyName("warnings")]
    public List<WarningValidationProblem> Warnings { get; init; }

    [JsonPropertyName("errors")]
    public List<ErrorValidationProblem> Errors { get; init; }

    [JsonPropertyName("logs")]
    public List<DebugModeLog>? Logs { get; init; }
}
