using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

public class TicketingContactResponse
{
    [JsonPropertyName("model")]
    public Contact Model { get; init; }

    [JsonPropertyName("warnings")]
    public IEnumerable<WarningValidationProblem> Warnings { get; init; }

    [JsonPropertyName("errors")]
    public IEnumerable<ErrorValidationProblem> Errors { get; init; }

    [JsonPropertyName("logs")]
    public IEnumerable<DebugModeLog>? Logs { get; init; }
}
