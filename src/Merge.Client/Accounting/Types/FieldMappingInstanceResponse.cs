using System.Text.Json.Serialization;
using Merge.Client.Accounting;

namespace Merge.Client.Accounting;

public class FieldMappingInstanceResponse
{
    [JsonPropertyName("model")]
    public FieldMappingApiInstance Model { get; init; }

    [JsonPropertyName("warnings")]
    public List<WarningValidationProblem> Warnings { get; init; }

    [JsonPropertyName("errors")]
    public List<ErrorValidationProblem> Errors { get; init; }

    [JsonPropertyName("logs")]
    public List<DebugModeLog>? Logs { get; init; }
}