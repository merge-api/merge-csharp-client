using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

namespace Merge.Client.Ticketing;

public class TicketingContactResponse
{
    [JsonPropertyName("model")]
    public Contact Model { get; init; }

    [JsonPropertyName("warnings")]
    public List<WarningValidationProblem> Warnings { get; init; }

    [JsonPropertyName("errors")]
    public List<ErrorValidationProblem> Errors { get; init; }

    [JsonPropertyName("logs")]
    public List<DebugModeLog>? Logs { get; init; }
}