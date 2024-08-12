using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public record UrlRequest
{
    /// <summary>
    /// The site's url.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// The type of site.
    ///
    /// - `PERSONAL` - PERSONAL
    /// - `COMPANY` - COMPANY
    /// - `PORTFOLIO` - PORTFOLIO
    /// - `BLOG` - BLOG
    /// - `SOCIAL_MEDIA` - SOCIAL_MEDIA
    /// - `OTHER` - OTHER
    /// - `JOB_POSTING` - JOB_POSTING
    /// </summary>
    [JsonPropertyName("url_type")]
    public UrlTypeEnum? UrlType { get; set; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }
}
