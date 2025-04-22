using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

public record AccountIntegration
{
    /// <summary>
    /// Company name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Optional. This shortened name appears in places with limited space, usually in conjunction with the platform's logo (e.g., Merge Link menu).&lt;br&gt;&lt;br&gt;Example: &lt;i&gt;Workforce Now (in lieu of ADP Workforce Now), SuccessFactors (in lieu of SAP SuccessFactors)&lt;/i&gt;
    /// </summary>
    [JsonPropertyName("abbreviated_name")]
    public string? AbbreviatedName { get; set; }

    /// <summary>
    /// Category or categories this integration belongs to. Multiple categories should be comma separated, i.e. [ats, hris].
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("categories")]
    public IEnumerable<CategoriesEnum>? Categories { get; set; }

    /// <summary>
    /// Company logo in rectangular shape.
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// Company logo in square shape.
    /// </summary>
    [JsonPropertyName("square_image")]
    public string? SquareImage { get; set; }

    /// <summary>
    /// The color of this integration used for buttons and text throughout the app and landing pages. &lt;b&gt;Choose a darker, saturated color.&lt;/b&gt;
    /// </summary>
    [JsonPropertyName("color")]
    public string? Color { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    /// <summary>
    /// Mapping of API endpoints to documentation urls for support. Example: {'GET': [['/common-model-scopes', 'https://docs.merge.dev/accounting/common-model-scopes/#common_model_scopes_retrieve'],['/common-model-actions', 'https://docs.merge.dev/accounting/common-model-actions/#common_model_actions_retrieve']], 'POST': []}
    /// </summary>
    [JsonPropertyName("api_endpoints_to_documentation_urls")]
    public Dictionary<string, object?>? ApiEndpointsToDocumentationUrls { get; set; }

    /// <summary>
    /// Setup guide URL for third party webhook creation. Exposed in Merge Docs.
    /// </summary>
    [JsonPropertyName("webhook_setup_guide_url")]
    public string? WebhookSetupGuideUrl { get; set; }

    /// <summary>
    /// Category or categories this integration is in beta status for.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("category_beta_status")]
    public Dictionary<string, object?>? CategoryBetaStatus { get; set; }

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
