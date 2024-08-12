using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public record IgnoreCommonModelRequest
{
    [JsonPropertyName("reason")]
    public required ReasonEnum Reason { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }
}
