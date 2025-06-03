using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ats;

/// <summary>
/// # The Url Object
/// ### Description
/// The `Url` object is used to represent hyperlinks associated with the parent model.
/// ### Usage Example
/// Fetch from the `GET Candidate` endpoint and view their website urls.
/// </summary>
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
    /// * `PERSONAL` - PERSONAL
    /// * `COMPANY` - COMPANY
    /// * `PORTFOLIO` - PORTFOLIO
    /// * `BLOG` - BLOG
    /// * `SOCIAL_MEDIA` - SOCIAL_MEDIA
    /// * `OTHER` - OTHER
    /// * `JOB_POSTING` - JOB_POSTING
    /// </summary>
    [JsonPropertyName("url_type")]
    public UrlTypeEnum? UrlType { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("integration_params")]
    public object? IntegrationParams { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("linked_account_params")]
    public object? LinkedAccountParams { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
