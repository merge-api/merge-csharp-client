using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public record AccountToken
{
    [JsonPropertyName("account_token")]
    public required string AccountToken_ { get; set; }

    [JsonPropertyName("integration")]
    public required AccountIntegration Integration { get; set; }
}
