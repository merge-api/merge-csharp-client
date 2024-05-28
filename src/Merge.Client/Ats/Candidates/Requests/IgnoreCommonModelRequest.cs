using System.Text.Json.Serialization;
using Merge.Client.Ats;

#nullable enable

namespace Merge.Client.Ats;

public class IgnoreCommonModelRequest
{
    [JsonPropertyName("reason")]
    public ReasonEnum Reason { get; init; }

    [JsonPropertyName("message")]
    public string? Message { get; init; }
}
