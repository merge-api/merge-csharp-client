using System.Text.Json.Serialization;
using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class UrlRequest
{
    /// <summary>
    /// The site's url.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; init; }

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
    public UrlTypeEnum? UrlType { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }
}
