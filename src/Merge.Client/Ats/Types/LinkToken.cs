using System.Text.Json.Serialization;

namespace Merge.Client.Ats;

public class LinkToken
{
    [JsonPropertyName("link_token")]
    public string LinkToken { get; init; }

    [JsonPropertyName("integration_name")]
    public string? IntegrationName { get; init; }

    [JsonPropertyName("magic_link_url")]
    public string? MagicLinkUrl { get; init; }
}
