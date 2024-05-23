using System.Text.Json.Serialization;
using Merge.Client.Hris;

namespace Merge.Client.Hris;

public class IgnoreCommonModelRequest
{
    [JsonPropertyName("reason")]
    public ReasonEnum Reason { get; init; }

    [JsonPropertyName("message")]
    public string? Message { get; init; }
}
