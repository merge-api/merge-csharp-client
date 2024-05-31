using System.Text.Json.Serialization;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class AccountIntegration
{
    /// <summary>
    /// Company name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Category or categories this integration belongs to. Multiple categories should be comma separated, i.e. [ats, hris].
    /// </summary>
    [JsonPropertyName("categories")]
    public IEnumerable<CategoriesEnum>? Categories { get; init; }

    /// <summary>
    /// Company logo in rectangular shape. <b>Upload an image with a clear background.</b>
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; init; }

    /// <summary>
    /// Company logo in square shape. <b>Upload an image with a white background.</b>
    /// </summary>
    [JsonPropertyName("square_image")]
    public string? SquareImage { get; init; }

    /// <summary>
    /// The color of this integration used for buttons and text throughout the app and landing pages. <b>Choose a darker, saturated color.</b>
    /// </summary>
    [JsonPropertyName("color")]
    public string? Color { get; init; }

    [JsonPropertyName("slug")]
    public string? Slug { get; init; }

    /// <summary>
    /// Mapping of API endpoints to documentation urls for support. Example: {'GET': [['/common-model-scopes', 'https://docs.merge.dev/accounting/common-model-scopes/#common_model_scopes_retrieve'],['/common-model-actions', 'https://docs.merge.dev/accounting/common-model-actions/#common_model_actions_retrieve']], 'POST': []}
    /// </summary>
    [JsonPropertyName("api_endpoints_to_documentation_urls")]
    public Dictionary<string, object>? ApiEndpointsToDocumentationUrls { get; init; }

    /// <summary>
    /// Setup guide URL for third party webhook creation. Exposed in Merge Docs.
    /// </summary>
    [JsonPropertyName("webhook_setup_guide_url")]
    public string? WebhookSetupGuideUrl { get; init; }

    /// <summary>
    /// Category or categories this integration is in beta status for.
    /// </summary>
    [JsonPropertyName("category_beta_status")]
    public Dictionary<string, object>? CategoryBetaStatus { get; init; }
}
