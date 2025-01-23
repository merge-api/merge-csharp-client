using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

public record AccountIntegration
{
    /// <summary>
    /// Company name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Optional. This shortened name appears in places with limited space, usually in conjunction with the platform's logo (e.g., Merge Link menu).<br><br>Example: <i>Workforce Now (in lieu of ADP Workforce Now), SuccessFactors (in lieu of SAP SuccessFactors)</i>
    /// </summary>
    [JsonPropertyName("abbreviated_name")]
    public string? AbbreviatedName { get; set; }

    /// <summary>
    /// Category or categories this integration belongs to. Multiple categories should be comma separated, i.e. [ats, hris].
    /// </summary>
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
    /// The color of this integration used for buttons and text throughout the app and landing pages. <b>Choose a darker, saturated color.</b>
    /// </summary>
    [JsonPropertyName("color")]
    public string? Color { get; set; }

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
    [JsonPropertyName("category_beta_status")]
    public Dictionary<string, object?>? CategoryBetaStatus { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
