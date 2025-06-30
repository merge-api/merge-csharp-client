using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<EventTypeEnum>))]
[Serializable]
public readonly record struct EventTypeEnum : IStringEnum
{
    public static readonly EventTypeEnum CreatedRemoteProductionApiKey = new(
        Values.CreatedRemoteProductionApiKey
    );

    public static readonly EventTypeEnum DeletedRemoteProductionApiKey = new(
        Values.DeletedRemoteProductionApiKey
    );

    public static readonly EventTypeEnum CreatedTestApiKey = new(Values.CreatedTestApiKey);

    public static readonly EventTypeEnum DeletedTestApiKey = new(Values.DeletedTestApiKey);

    public static readonly EventTypeEnum RegeneratedProductionApiKey = new(
        Values.RegeneratedProductionApiKey
    );

    public static readonly EventTypeEnum RegeneratedWebhookSignature = new(
        Values.RegeneratedWebhookSignature
    );

    public static readonly EventTypeEnum InvitedUser = new(Values.InvitedUser);

    public static readonly EventTypeEnum TwoFactorAuthEnabled = new(Values.TwoFactorAuthEnabled);

    public static readonly EventTypeEnum TwoFactorAuthDisabled = new(Values.TwoFactorAuthDisabled);

    public static readonly EventTypeEnum DeletedLinkedAccount = new(Values.DeletedLinkedAccount);

    public static readonly EventTypeEnum DeletedAllCommonModelsForLinkedAccount = new(
        Values.DeletedAllCommonModelsForLinkedAccount
    );

    public static readonly EventTypeEnum CreatedDestination = new(Values.CreatedDestination);

    public static readonly EventTypeEnum DeletedDestination = new(Values.DeletedDestination);

    public static readonly EventTypeEnum ChangedDestination = new(Values.ChangedDestination);

    public static readonly EventTypeEnum ChangedScopes = new(Values.ChangedScopes);

    public static readonly EventTypeEnum ChangedPersonalInformation = new(
        Values.ChangedPersonalInformation
    );

    public static readonly EventTypeEnum ChangedOrganizationSettings = new(
        Values.ChangedOrganizationSettings
    );

    public static readonly EventTypeEnum EnabledIntegration = new(Values.EnabledIntegration);

    public static readonly EventTypeEnum DisabledIntegration = new(Values.DisabledIntegration);

    public static readonly EventTypeEnum EnabledCategory = new(Values.EnabledCategory);

    public static readonly EventTypeEnum DisabledCategory = new(Values.DisabledCategory);

    public static readonly EventTypeEnum ChangedPassword = new(Values.ChangedPassword);

    public static readonly EventTypeEnum ResetPassword = new(Values.ResetPassword);

    public static readonly EventTypeEnum EnabledRedactUnmappedDataForOrganization = new(
        Values.EnabledRedactUnmappedDataForOrganization
    );

    public static readonly EventTypeEnum EnabledRedactUnmappedDataForLinkedAccount = new(
        Values.EnabledRedactUnmappedDataForLinkedAccount
    );

    public static readonly EventTypeEnum DisabledRedactUnmappedDataForOrganization = new(
        Values.DisabledRedactUnmappedDataForOrganization
    );

    public static readonly EventTypeEnum DisabledRedactUnmappedDataForLinkedAccount = new(
        Values.DisabledRedactUnmappedDataForLinkedAccount
    );

    public static readonly EventTypeEnum CreatedIntegrationWideFieldMapping = new(
        Values.CreatedIntegrationWideFieldMapping
    );

    public static readonly EventTypeEnum CreatedLinkedAccountFieldMapping = new(
        Values.CreatedLinkedAccountFieldMapping
    );

    public static readonly EventTypeEnum ChangedIntegrationWideFieldMapping = new(
        Values.ChangedIntegrationWideFieldMapping
    );

    public static readonly EventTypeEnum ChangedLinkedAccountFieldMapping = new(
        Values.ChangedLinkedAccountFieldMapping
    );

    public static readonly EventTypeEnum DeletedIntegrationWideFieldMapping = new(
        Values.DeletedIntegrationWideFieldMapping
    );

    public static readonly EventTypeEnum DeletedLinkedAccountFieldMapping = new(
        Values.DeletedLinkedAccountFieldMapping
    );

    public static readonly EventTypeEnum CreatedLinkedAccountCommonModelOverride = new(
        Values.CreatedLinkedAccountCommonModelOverride
    );

    public static readonly EventTypeEnum ChangedLinkedAccountCommonModelOverride = new(
        Values.ChangedLinkedAccountCommonModelOverride
    );

    public static readonly EventTypeEnum DeletedLinkedAccountCommonModelOverride = new(
        Values.DeletedLinkedAccountCommonModelOverride
    );

    public static readonly EventTypeEnum ForcedLinkedAccountResync = new(
        Values.ForcedLinkedAccountResync
    );

    public static readonly EventTypeEnum MutedIssue = new(Values.MutedIssue);

    public static readonly EventTypeEnum GeneratedMagicLink = new(Values.GeneratedMagicLink);

    public static readonly EventTypeEnum EnabledMergeWebhook = new(Values.EnabledMergeWebhook);

    public static readonly EventTypeEnum DisabledMergeWebhook = new(Values.DisabledMergeWebhook);

    public static readonly EventTypeEnum MergeWebhookTargetChanged = new(
        Values.MergeWebhookTargetChanged
    );

    public static readonly EventTypeEnum EndUserCredentialsAccessed = new(
        Values.EndUserCredentialsAccessed
    );

    public EventTypeEnum(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static EventTypeEnum FromCustom(string value)
    {
        return new EventTypeEnum(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(EventTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EventTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EventTypeEnum value) => value.Value;

    public static explicit operator EventTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string CreatedRemoteProductionApiKey = "CREATED_REMOTE_PRODUCTION_API_KEY";

        public const string DeletedRemoteProductionApiKey = "DELETED_REMOTE_PRODUCTION_API_KEY";

        public const string CreatedTestApiKey = "CREATED_TEST_API_KEY";

        public const string DeletedTestApiKey = "DELETED_TEST_API_KEY";

        public const string RegeneratedProductionApiKey = "REGENERATED_PRODUCTION_API_KEY";

        public const string RegeneratedWebhookSignature = "REGENERATED_WEBHOOK_SIGNATURE";

        public const string InvitedUser = "INVITED_USER";

        public const string TwoFactorAuthEnabled = "TWO_FACTOR_AUTH_ENABLED";

        public const string TwoFactorAuthDisabled = "TWO_FACTOR_AUTH_DISABLED";

        public const string DeletedLinkedAccount = "DELETED_LINKED_ACCOUNT";

        public const string DeletedAllCommonModelsForLinkedAccount =
            "DELETED_ALL_COMMON_MODELS_FOR_LINKED_ACCOUNT";

        public const string CreatedDestination = "CREATED_DESTINATION";

        public const string DeletedDestination = "DELETED_DESTINATION";

        public const string ChangedDestination = "CHANGED_DESTINATION";

        public const string ChangedScopes = "CHANGED_SCOPES";

        public const string ChangedPersonalInformation = "CHANGED_PERSONAL_INFORMATION";

        public const string ChangedOrganizationSettings = "CHANGED_ORGANIZATION_SETTINGS";

        public const string EnabledIntegration = "ENABLED_INTEGRATION";

        public const string DisabledIntegration = "DISABLED_INTEGRATION";

        public const string EnabledCategory = "ENABLED_CATEGORY";

        public const string DisabledCategory = "DISABLED_CATEGORY";

        public const string ChangedPassword = "CHANGED_PASSWORD";

        public const string ResetPassword = "RESET_PASSWORD";

        public const string EnabledRedactUnmappedDataForOrganization =
            "ENABLED_REDACT_UNMAPPED_DATA_FOR_ORGANIZATION";

        public const string EnabledRedactUnmappedDataForLinkedAccount =
            "ENABLED_REDACT_UNMAPPED_DATA_FOR_LINKED_ACCOUNT";

        public const string DisabledRedactUnmappedDataForOrganization =
            "DISABLED_REDACT_UNMAPPED_DATA_FOR_ORGANIZATION";

        public const string DisabledRedactUnmappedDataForLinkedAccount =
            "DISABLED_REDACT_UNMAPPED_DATA_FOR_LINKED_ACCOUNT";

        public const string CreatedIntegrationWideFieldMapping =
            "CREATED_INTEGRATION_WIDE_FIELD_MAPPING";

        public const string CreatedLinkedAccountFieldMapping =
            "CREATED_LINKED_ACCOUNT_FIELD_MAPPING";

        public const string ChangedIntegrationWideFieldMapping =
            "CHANGED_INTEGRATION_WIDE_FIELD_MAPPING";

        public const string ChangedLinkedAccountFieldMapping =
            "CHANGED_LINKED_ACCOUNT_FIELD_MAPPING";

        public const string DeletedIntegrationWideFieldMapping =
            "DELETED_INTEGRATION_WIDE_FIELD_MAPPING";

        public const string DeletedLinkedAccountFieldMapping =
            "DELETED_LINKED_ACCOUNT_FIELD_MAPPING";

        public const string CreatedLinkedAccountCommonModelOverride =
            "CREATED_LINKED_ACCOUNT_COMMON_MODEL_OVERRIDE";

        public const string ChangedLinkedAccountCommonModelOverride =
            "CHANGED_LINKED_ACCOUNT_COMMON_MODEL_OVERRIDE";

        public const string DeletedLinkedAccountCommonModelOverride =
            "DELETED_LINKED_ACCOUNT_COMMON_MODEL_OVERRIDE";

        public const string ForcedLinkedAccountResync = "FORCED_LINKED_ACCOUNT_RESYNC";

        public const string MutedIssue = "MUTED_ISSUE";

        public const string GeneratedMagicLink = "GENERATED_MAGIC_LINK";

        public const string EnabledMergeWebhook = "ENABLED_MERGE_WEBHOOK";

        public const string DisabledMergeWebhook = "DISABLED_MERGE_WEBHOOK";

        public const string MergeWebhookTargetChanged = "MERGE_WEBHOOK_TARGET_CHANGED";

        public const string EndUserCredentialsAccessed = "END_USER_CREDENTIALS_ACCESSED";
    }
}
