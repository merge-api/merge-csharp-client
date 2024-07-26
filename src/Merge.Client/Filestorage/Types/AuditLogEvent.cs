using System.Text.Json.Serialization;
using Merge.Client.Filestorage;

#nullable enable

namespace Merge.Client.Filestorage;

public class AuditLogEvent
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The User's full name at the time of this Event occurring.
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; init; }

    /// <summary>
    /// The User's email at the time of this Event occurring.
    /// </summary>
    [JsonPropertyName("user_email")]
    public string? UserEmail { get; init; }

    /// <summary>
    /// Designates the role of the user (or SYSTEM/API if action not taken by a user) at the time of this Event occurring.
    ///
    /// - `ADMIN` - ADMIN
    /// - `DEVELOPER` - DEVELOPER
    /// - `MEMBER` - MEMBER
    /// - `API` - API
    /// - `SYSTEM` - SYSTEM
    /// - `MERGE_TEAM` - MERGE_TEAM
    /// </summary>
    [JsonPropertyName("role")]
    public RoleEnum Role { get; init; }

    [JsonPropertyName("ip_address")]
    public string IpAddress { get; init; }

    /// <summary>
    /// Designates the type of event that occurred.
    ///
    /// - `CREATED_REMOTE_PRODUCTION_API_KEY` - CREATED_REMOTE_PRODUCTION_API_KEY
    /// - `DELETED_REMOTE_PRODUCTION_API_KEY` - DELETED_REMOTE_PRODUCTION_API_KEY
    /// - `CREATED_TEST_API_KEY` - CREATED_TEST_API_KEY
    /// - `DELETED_TEST_API_KEY` - DELETED_TEST_API_KEY
    /// - `REGENERATED_PRODUCTION_API_KEY` - REGENERATED_PRODUCTION_API_KEY
    /// - `INVITED_USER` - INVITED_USER
    /// - `TWO_FACTOR_AUTH_ENABLED` - TWO_FACTOR_AUTH_ENABLED
    /// - `TWO_FACTOR_AUTH_DISABLED` - TWO_FACTOR_AUTH_DISABLED
    /// - `DELETED_LINKED_ACCOUNT` - DELETED_LINKED_ACCOUNT
    /// - `CREATED_DESTINATION` - CREATED_DESTINATION
    /// - `DELETED_DESTINATION` - DELETED_DESTINATION
    /// - `CHANGED_DESTINATION` - CHANGED_DESTINATION
    /// - `CHANGED_SCOPES` - CHANGED_SCOPES
    /// - `CHANGED_PERSONAL_INFORMATION` - CHANGED_PERSONAL_INFORMATION
    /// - `CHANGED_ORGANIZATION_SETTINGS` - CHANGED_ORGANIZATION_SETTINGS
    /// - `ENABLED_INTEGRATION` - ENABLED_INTEGRATION
    /// - `DISABLED_INTEGRATION` - DISABLED_INTEGRATION
    /// - `ENABLED_CATEGORY` - ENABLED_CATEGORY
    /// - `DISABLED_CATEGORY` - DISABLED_CATEGORY
    /// - `CHANGED_PASSWORD` - CHANGED_PASSWORD
    /// - `RESET_PASSWORD` - RESET_PASSWORD
    /// - `ENABLED_REDACT_UNMAPPED_DATA_FOR_ORGANIZATION` - ENABLED_REDACT_UNMAPPED_DATA_FOR_ORGANIZATION
    /// - `ENABLED_REDACT_UNMAPPED_DATA_FOR_LINKED_ACCOUNT` - ENABLED_REDACT_UNMAPPED_DATA_FOR_LINKED_ACCOUNT
    /// - `DISABLED_REDACT_UNMAPPED_DATA_FOR_ORGANIZATION` - DISABLED_REDACT_UNMAPPED_DATA_FOR_ORGANIZATION
    /// - `DISABLED_REDACT_UNMAPPED_DATA_FOR_LINKED_ACCOUNT` - DISABLED_REDACT_UNMAPPED_DATA_FOR_LINKED_ACCOUNT
    /// - `CREATED_INTEGRATION_WIDE_FIELD_MAPPING` - CREATED_INTEGRATION_WIDE_FIELD_MAPPING
    /// - `CREATED_LINKED_ACCOUNT_FIELD_MAPPING` - CREATED_LINKED_ACCOUNT_FIELD_MAPPING
    /// - `CHANGED_INTEGRATION_WIDE_FIELD_MAPPING` - CHANGED_INTEGRATION_WIDE_FIELD_MAPPING
    /// - `CHANGED_LINKED_ACCOUNT_FIELD_MAPPING` - CHANGED_LINKED_ACCOUNT_FIELD_MAPPING
    /// - `DELETED_INTEGRATION_WIDE_FIELD_MAPPING` - DELETED_INTEGRATION_WIDE_FIELD_MAPPING
    /// - `DELETED_LINKED_ACCOUNT_FIELD_MAPPING` - DELETED_LINKED_ACCOUNT_FIELD_MAPPING
    /// - `FORCED_LINKED_ACCOUNT_RESYNC` - FORCED_LINKED_ACCOUNT_RESYNC
    /// - `MUTED_ISSUE` - MUTED_ISSUE
    /// - `GENERATED_MAGIC_LINK` - GENERATED_MAGIC_LINK
    /// - `ENABLED_MERGE_WEBHOOK` - ENABLED_MERGE_WEBHOOK
    /// - `DISABLED_MERGE_WEBHOOK` - DISABLED_MERGE_WEBHOOK
    /// - `MERGE_WEBHOOK_TARGET_CHANGED` - MERGE_WEBHOOK_TARGET_CHANGED
    /// - `END_USER_CREDENTIALS_ACCESSED` - END_USER_CREDENTIALS_ACCESSED
    /// </summary>
    [JsonPropertyName("event_type")]
    public EventTypeEnum EventType { get; init; }

    [JsonPropertyName("event_description")]
    public string EventDescription { get; init; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }
}
