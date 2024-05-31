using System.Text.Json.Serialization;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class CrmCustomObjectResponse
{
    [JsonPropertyName("model")]
    public CustomObject Model { get; init; }

    [JsonPropertyName("warnings")]
    public IEnumerable<WarningValidationProblem> Warnings { get; init; }

    [JsonPropertyName("errors")]
    public IEnumerable<ErrorValidationProblem> Errors { get; init; }

    [JsonPropertyName("logs")]
    public IEnumerable<DebugModeLog>? Logs { get; init; }
}
