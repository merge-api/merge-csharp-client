using System.Text.Json.Serialization;
using StringEnum;
using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class Url
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
    public StringEnum<UrlTypeEnum>? UrlType { get; init; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// This is the datetime that this object was last updated by Merge
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }
}
