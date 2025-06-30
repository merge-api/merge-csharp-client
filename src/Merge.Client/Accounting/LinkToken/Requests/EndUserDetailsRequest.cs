using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Accounting;

[Serializable]
public record EndUserDetailsRequest
{
    /// <summary>
    /// Your end user's email address. This is purely for identification purposes - setting this value will not cause any emails to be sent.
    /// </summary>
    [JsonPropertyName("end_user_email_address")]
    public required string EndUserEmailAddress { get; set; }

    /// <summary>
    /// Your end user's organization.
    /// </summary>
    [JsonPropertyName("end_user_organization_name")]
    public required string EndUserOrganizationName { get; set; }

    /// <summary>
    /// This unique identifier typically represents the ID for your end user in your product's database. This value must be distinct from other Linked Accounts' unique identifiers.
    /// </summary>
    [JsonPropertyName("end_user_origin_id")]
    public required string EndUserOriginId { get; set; }

    /// <summary>
    /// The integration categories to show in Merge Link.
    /// </summary>
    [JsonPropertyName("categories")]
    public IEnumerable<CategoriesEnum> Categories { get; set; } = new List<CategoriesEnum>();

    /// <summary>
    /// The slug of a specific pre-selected integration for this linking flow token. For examples of slugs, see https://docs.merge.dev/guides/merge-link/single-integration/.
    /// </summary>
    [JsonPropertyName("integration")]
    public string? Integration { get; set; }

    /// <summary>
    /// An integer number of minutes between [30, 720 or 10080 if for a Magic Link URL] for how long this token is valid. Defaults to 30.
    /// </summary>
    [JsonPropertyName("link_expiry_mins")]
    public int? LinkExpiryMins { get; set; }

    /// <summary>
    /// Whether to generate a Magic Link URL. Defaults to false. For more information on Magic Link, see https://merge.dev/blog/integrations-fast-say-hello-to-magic-link.
    /// </summary>
    [JsonPropertyName("should_create_magic_link_url")]
    public bool? ShouldCreateMagicLinkUrl { get; set; }

    /// <summary>
    /// Whether to generate a Magic Link URL on the Admin Needed screen during the linking flow. Defaults to false. For more information on Magic Link, see https://merge.dev/blog/integrations-fast-say-hello-to-magic-link.
    /// </summary>
    [JsonPropertyName("hide_admin_magic_link")]
    public bool? HideAdminMagicLink { get; set; }

    /// <summary>
    /// An array of objects to specify the models and fields that will be disabled for a given Linked Account. Each object uses model_id, enabled_actions, and disabled_fields to specify the model, method, and fields that are scoped for a given Linked Account.
    /// </summary>
    [JsonPropertyName("common_models")]
    public IEnumerable<CommonModelScopesBodyRequest>? CommonModels { get; set; }

    /// <summary>
    /// When creating a Link Token, you can set permissions for Common Models that will apply to the account that is going to be linked. Any model or field not specified in link token payload will default to existing settings.
    /// </summary>
    [JsonPropertyName("category_common_model_scopes")]
    public Dictionary<
        string,
        IEnumerable<IndividualCommonModelScopeDeserializerRequest>?
    >? CategoryCommonModelScopes { get; set; }

    /// <summary>
    /// The following subset of IETF language tags can be used to configure localization.
    ///
    /// * `en` - en
    /// * `de` - de
    /// </summary>
    [JsonPropertyName("language")]
    public OneOf<LanguageEnum, string>? Language { get; set; }

    /// <summary>
    /// The boolean that indicates whether initial, periodic, and force syncs will be disabled.
    /// </summary>
    [JsonPropertyName("are_syncs_disabled")]
    public bool? AreSyncsDisabled { get; set; }

    /// <summary>
    /// A JSON object containing integration-specific configuration options.
    /// </summary>
    [JsonPropertyName("integration_specific_config")]
    public Dictionary<string, object?>? IntegrationSpecificConfig { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
