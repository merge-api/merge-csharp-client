using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

public record AccountToken
{
    [JsonPropertyName("account_token")]
    public required string AccountToken_ { get; set; }

    [JsonPropertyName("integration")]
    public required AccountIntegration Integration { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
