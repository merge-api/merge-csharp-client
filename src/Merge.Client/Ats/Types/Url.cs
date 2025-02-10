using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

public record Url
{
    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

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

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
