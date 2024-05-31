using System.Text.Json.Serialization;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

public class AccountingAttachmentResponse
{
    [JsonPropertyName("model")]
    public AccountingAttachment Model { get; init; }

    [JsonPropertyName("warnings")]
    public IEnumerable<WarningValidationProblem> Warnings { get; init; }

    [JsonPropertyName("errors")]
    public IEnumerable<ErrorValidationProblem> Errors { get; init; }

    [JsonPropertyName("logs")]
    public IEnumerable<DebugModeLog>? Logs { get; init; }
}
