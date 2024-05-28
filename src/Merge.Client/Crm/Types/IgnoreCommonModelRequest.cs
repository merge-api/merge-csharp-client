using System.Text.Json.Serialization;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class IgnoreCommonModelRequest
{
    [JsonPropertyName("reason")]
    public ReasonEnum Reason { get; init; }

    [JsonPropertyName("message")]
    public string? Message { get; init; }
}
