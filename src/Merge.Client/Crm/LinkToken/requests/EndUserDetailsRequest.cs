using System.Text.Json.Serialization;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class EndUserDetailsRequest
{
    /// <summary>
    /// Your end user's email address. This is purely for identification purposes - setting this value will not cause any emails to be sent.
    /// </summary>
    [JsonPropertyName("end_user_email_address")]
    public string EndUserEmailAddress { get; init; }

    /// <summary>
    /// Your end user's organization.
    /// </summary>
    [JsonPropertyName("end_user_organization_name")]
    public string EndUserOrganizationName { get; init; }

    /// <summary>
    /// This unique identifier typically represents the ID for your end user in your product's database. This value must be distinct from other Linked Accounts' unique identifiers.
    /// </summary>
    [JsonPropertyName("end_user_origin_id")]
    public string EndUserOriginId { get; init; }

    /// <summary>
    /// The integration categories to show in Merge Link.
    /// </summary>
    [JsonPropertyName("categories")]
    public List<CategoriesEnum> Categories { get; init; }

    /// <summary>
    /// The slug of a specific pre-selected integration for this linking flow token. For examples of slugs, see https://docs.merge.dev/guides/merge-link/single-integration/.
    /// </summary>
    [JsonPropertyName("integration")]
    public string? Integration { get; init; }

    /// <summary>
    /// An integer number of minutes between [30, 720 or 10080 if for a Magic Link URL] for how long this token is valid. Defaults to 30.
    /// </summary>
    [JsonPropertyName("link_expiry_mins")]
    public int? LinkExpiryMins { get; init; }

    /// <summary>
    /// Whether to generate a Magic Link URL. Defaults to false. For more information on Magic Link, see https://merge.dev/blog/integrations-fast-say-hello-to-magic-link.
    /// </summary>
    [JsonPropertyName("should_create_magic_link_url")]
    public bool? ShouldCreateMagicLinkUrl { get; init; }

    /// <summary>
    /// An array of objects to specify the models and fields that will be disabled for a given Linked Account. Each object uses model_id, enabled_actions, and disabled_fields to specify the model, method, and fields that are scoped for a given Linked Account.
    /// </summary>
    [JsonPropertyName("common_models")]
    public List<CommonModelScopesBodyRequest>? CommonModels { get; init; }

    /// <summary>
    /// When creating a Link Token, you can set permissions for Common Models that will apply to the account that is going to be linked. Any model or field not specified in link token payload will default to existing settings.
    /// </summary>
    [JsonPropertyName("category_common_model_scopes")]
    public Dictionary<
        string,
        List<IndividualCommonModelScopeDeserializerRequest>?
    >? CategoryCommonModelScopes { get; init; }

    /// <summary>
    /// The language code for the language to localize Merge Link to.
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; init; }

    /// <summary>
    /// A JSON object containing integration-specific configuration options.
    /// </summary>
    [JsonPropertyName("integration_specific_config")]
    public Dictionary<string, object>? IntegrationSpecificConfig { get; init; }
}
