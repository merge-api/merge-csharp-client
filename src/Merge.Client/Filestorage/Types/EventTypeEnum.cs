using System.Runtime.Serialization;

namespace Merge.Client.Filestorage;

public enum EventTypeEnum
{
    [EnumMember(Value = "CREATED_REMOTE_PRODUCTION_API_KEY")]
    CreatedRemoteProductionApiKey,

    [EnumMember(Value = "DELETED_REMOTE_PRODUCTION_API_KEY")]
    DeletedRemoteProductionApiKey,

    [EnumMember(Value = "CREATED_TEST_API_KEY")]
    CreatedTestApiKey,

    [EnumMember(Value = "DELETED_TEST_API_KEY")]
    DeletedTestApiKey,

    [EnumMember(Value = "REGENERATED_PRODUCTION_API_KEY")]
    RegeneratedProductionApiKey,

    [EnumMember(Value = "INVITED_USER")]
    InvitedUser,

    [EnumMember(Value = "TWO_FACTOR_AUTH_ENABLED")]
    TwoFactorAuthEnabled,

    [EnumMember(Value = "TWO_FACTOR_AUTH_DISABLED")]
    TwoFactorAuthDisabled,

    [EnumMember(Value = "DELETED_LINKED_ACCOUNT")]
    DeletedLinkedAccount,

    [EnumMember(Value = "CREATED_DESTINATION")]
    CreatedDestination,

    [EnumMember(Value = "DELETED_DESTINATION")]
    DeletedDestination,

    [EnumMember(Value = "CHANGED_SCOPES")]
    ChangedScopes,

    [EnumMember(Value = "CHANGED_PERSONAL_INFORMATION")]
    ChangedPersonalInformation,

    [EnumMember(Value = "CHANGED_ORGANIZATION_SETTINGS")]
    ChangedOrganizationSettings,

    [EnumMember(Value = "ENABLED_INTEGRATION")]
    EnabledIntegration,

    [EnumMember(Value = "DISABLED_INTEGRATION")]
    DisabledIntegration,

    [EnumMember(Value = "ENABLED_CATEGORY")]
    EnabledCategory,

    [EnumMember(Value = "DISABLED_CATEGORY")]
    DisabledCategory,

    [EnumMember(Value = "CHANGED_PASSWORD")]
    ChangedPassword,

    [EnumMember(Value = "RESET_PASSWORD")]
    ResetPassword,

    [EnumMember(Value = "ENABLED_REDACT_UNMAPPED_DATA_FOR_ORGANIZATION")]
    EnabledRedactUnmappedDataForOrganization,

    [EnumMember(Value = "ENABLED_REDACT_UNMAPPED_DATA_FOR_LINKED_ACCOUNT")]
    EnabledRedactUnmappedDataForLinkedAccount,

    [EnumMember(Value = "DISABLED_REDACT_UNMAPPED_DATA_FOR_ORGANIZATION")]
    DisabledRedactUnmappedDataForOrganization,

    [EnumMember(Value = "DISABLED_REDACT_UNMAPPED_DATA_FOR_LINKED_ACCOUNT")]
    DisabledRedactUnmappedDataForLinkedAccount,

    [EnumMember(Value = "CREATED_INTEGRATION_WIDE_FIELD_MAPPING")]
    CreatedIntegrationWideFieldMapping,

    [EnumMember(Value = "CREATED_LINKED_ACCOUNT_FIELD_MAPPING")]
    CreatedLinkedAccountFieldMapping,

    [EnumMember(Value = "CHANGED_INTEGRATION_WIDE_FIELD_MAPPING")]
    ChangedIntegrationWideFieldMapping,

    [EnumMember(Value = "CHANGED_LINKED_ACCOUNT_FIELD_MAPPING")]
    ChangedLinkedAccountFieldMapping,

    [EnumMember(Value = "DELETED_INTEGRATION_WIDE_FIELD_MAPPING")]
    DeletedIntegrationWideFieldMapping,

    [EnumMember(Value = "DELETED_LINKED_ACCOUNT_FIELD_MAPPING")]
    DeletedLinkedAccountFieldMapping
}
