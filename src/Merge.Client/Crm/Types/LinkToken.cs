using System.Text.Json.Serialization;

namespace Merge.Client.Crm;

public class LinkToken
{
    [JsonPropertyName("link_token")]
    public string LinkToken_ { get; init; }

    [JsonPropertyName("integration_name")]
    public string? IntegrationName { get; init; }

    [JsonPropertyName("magic_link_url")]
    public string? MagicLinkUrl { get; init; }
}
