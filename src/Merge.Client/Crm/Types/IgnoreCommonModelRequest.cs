using System.Text.Json.Serialization;
using StringEnum;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class IgnoreCommonModelRequest
{
    [JsonPropertyName("reason")]
    public StringEnum<ReasonEnum> Reason { get; init; }

    [JsonPropertyName("message")]
    public string? Message { get; init; }
}
