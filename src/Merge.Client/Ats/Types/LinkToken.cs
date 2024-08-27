using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

public record LinkToken
{
    [JsonPropertyName("link_token")]
    public required string LinkToken_ { get; set; }

    [JsonPropertyName("integration_name")]
    public string? IntegrationName { get; set; }

    [JsonPropertyName("magic_link_url")]
    public string? MagicLinkUrl { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
