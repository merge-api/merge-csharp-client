using System.Text.Json.Serialization;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

public class PurchaseOrderResponse
{
    [JsonPropertyName("model")]
    public PurchaseOrder Model { get; init; }

    [JsonPropertyName("warnings")]
    public List<WarningValidationProblem> Warnings { get; init; }

    [JsonPropertyName("errors")]
    public List<ErrorValidationProblem> Errors { get; init; }

    [JsonPropertyName("logs")]
    public List<DebugModeLog>? Logs { get; init; }
}
