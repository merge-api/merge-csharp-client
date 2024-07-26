namespace Merge.Client.Ticketing;

public class AuditTrailListRequest
{
    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// If included, will only include audit trail events that occurred before this time
    /// </summary>
    public string? EndDate { get; init; }

    /// <summary>
    /// If included, will only include events with the given event type. Possible values include: `CREATED_REMOTE_PRODUCTION_API_KEY`, `DELETED_REMOTE_PRODUCTION_API_KEY`, `CREATED_TEST_API_KEY`, `DELETED_TEST_API_KEY`, `REGENERATED_PRODUCTION_API_KEY`, `INVITED_USER`, `TWO_FACTOR_AUTH_ENABLED`, `TWO_FACTOR_AUTH_DISABLED`, `DELETED_LINKED_ACCOUNT`, `CREATED_DESTINATION`, `DELETED_DESTINATION`, `CHANGED_DESTINATION`, `CHANGED_SCOPES`, `CHANGED_PERSONAL_INFORMATION`, `CHANGED_ORGANIZATION_SETTINGS`, `ENABLED_INTEGRATION`, `DISABLED_INTEGRATION`, `ENABLED_CATEGORY`, `DISABLED_CATEGORY`, `CHANGED_PASSWORD`, `RESET_PASSWORD`, `ENABLED_REDACT_UNMAPPED_DATA_FOR_ORGANIZATION`, `ENABLED_REDACT_UNMAPPED_DATA_FOR_LINKED_ACCOUNT`, `DISABLED_REDACT_UNMAPPED_DATA_FOR_ORGANIZATION`, `DISABLED_REDACT_UNMAPPED_DATA_FOR_LINKED_ACCOUNT`, `CREATED_INTEGRATION_WIDE_FIELD_MAPPING`, `CREATED_LINKED_ACCOUNT_FIELD_MAPPING`, `CHANGED_INTEGRATION_WIDE_FIELD_MAPPING`, `CHANGED_LINKED_ACCOUNT_FIELD_MAPPING`, `DELETED_INTEGRATION_WIDE_FIELD_MAPPING`, `DELETED_LINKED_ACCOUNT_FIELD_MAPPING`, `FORCED_LINKED_ACCOUNT_RESYNC`, `MUTED_ISSUE`, `GENERATED_MAGIC_LINK`, `ENABLED_MERGE_WEBHOOK`, `DISABLED_MERGE_WEBHOOK`, `MERGE_WEBHOOK_TARGET_CHANGED`, `END_USER_CREDENTIALS_ACCESSED`
    /// </summary>
    public string? EventType { get; init; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// If included, will only include audit trail events that occurred after this time
    /// </summary>
    public string? StartDate { get; init; }

    /// <summary>
    /// If provided, this will return events associated with the specified user email. Please note that the email address reflects the user's email at the time of the event, and may not be their current email.
    /// </summary>
    public string? UserEmail { get; init; }
}
