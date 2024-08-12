namespace Merge.Client.Ticketing;

public record TicketsListRequest
{
    /// <summary>
    /// If provided, will only return tickets for this account.
    /// </summary>
    public string? AccountId { get; set; }

    /// <summary>
    /// If provided, will only return tickets assigned to the assignee_ids; multiple assignee_ids can be separated by commas.
    /// </summary>
    public string? AssigneeIds { get; set; }

    /// <summary>
    /// If provided, will only return tickets assigned to the collection_ids; multiple collection_ids can be separated by commas.
    /// </summary>
    public string? CollectionIds { get; set; }

    /// <summary>
    /// If provided, will only return tickets completed after this datetime.
    /// </summary>
    public DateTime? CompletedAfter { get; set; }

    /// <summary>
    /// If provided, will only return tickets completed before this datetime.
    /// </summary>
    public DateTime? CompletedBefore { get; set; }

    /// <summary>
    /// If provided, will only return tickets for this contact.
    /// </summary>
    public string? ContactId { get; set; }

    /// <summary>
    /// If provided, will only return objects created after this datetime.
    /// </summary>
    public DateTime? CreatedAfter { get; set; }

    /// <summary>
    /// If provided, will only return objects created before this datetime.
    /// </summary>
    public DateTime? CreatedBefore { get; set; }

    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    public string? Cursor { get; set; }

    /// <summary>
    /// If provided, will only return tickets due after this datetime.
    /// </summary>
    public DateTime? DueAfter { get; set; }

    /// <summary>
    /// If provided, will only return tickets due before this datetime.
    /// </summary>
    public DateTime? DueBefore { get; set; }

    /// <summary>
    /// Which relations should be returned in expanded form. Multiple relation names should be comma separated without spaces.
    /// </summary>
    public TicketsListRequestExpand? Expand { get; set; }

    /// <summary>
    /// Whether to include data that was marked as deleted by third party webhooks.
    /// </summary>
    public bool? IncludeDeletedData { get; set; }

    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; set; }

    /// <summary>
    /// Whether to include all remote fields, including fields that Merge did not map to common models, in a normalized format.
    /// </summary>
    public bool? IncludeRemoteFields { get; set; }

    /// <summary>
    /// If provided, only objects synced by Merge after this date time will be returned.
    /// </summary>
    public DateTime? ModifiedAfter { get; set; }

    /// <summary>
    /// If provided, only objects synced by Merge before this date time will be returned.
    /// </summary>
    public DateTime? ModifiedBefore { get; set; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// If provided, will only return sub tickets of the parent_ticket_id.
    /// </summary>
    public string? ParentTicketId { get; set; }

    /// <summary>
    /// If provided, will only return tickets of this priority.
    ///
    /// - `URGENT` - URGENT
    /// - `HIGH` - HIGH
    /// - `NORMAL` - NORMAL
    /// - `LOW` - LOW
    /// </summary>
    public TicketsListRequestPriority? Priority { get; set; }

    /// <summary>
    /// If provided, will only return tickets created in the third party platform after this datetime.
    /// </summary>
    public DateTime? RemoteCreatedAfter { get; set; }

    /// <summary>
    /// If provided, will only return tickets created in the third party platform before this datetime.
    /// </summary>
    public DateTime? RemoteCreatedBefore { get; set; }

    /// <summary>
    /// Deprecated. Use show_enum_origins.
    /// </summary>
    public TicketsListRequestRemoteFields? RemoteFields { get; set; }

    /// <summary>
    /// The API provider's ID for the given object.
    /// </summary>
    public string? RemoteId { get; set; }

    /// <summary>
    /// If provided, will only return tickets updated in the third party platform after this datetime.
    /// </summary>
    public DateTime? RemoteUpdatedAfter { get; set; }

    /// <summary>
    /// If provided, will only return tickets updated in the third party platform before this datetime.
    /// </summary>
    public DateTime? RemoteUpdatedBefore { get; set; }

    /// <summary>
    /// A comma separated list of enum field names for which you'd like the original values to be returned, instead of Merge's normalized enum values. [Learn more](https://help.merge.dev/en/articles/8950958-show_enum_origins-query-parameter)
    /// </summary>
    public TicketsListRequestShowEnumOrigins? ShowEnumOrigins { get; set; }

    /// <summary>
    /// If provided, will only return tickets of this status.
    ///
    /// - `OPEN` - OPEN
    /// - `CLOSED` - CLOSED
    /// - `IN_PROGRESS` - IN_PROGRESS
    /// - `ON_HOLD` - ON_HOLD
    /// </summary>
    public TicketsListRequestStatus? Status { get; set; }

    /// <summary>
    /// If provided, will only return tickets matching the tags; multiple tags can be separated by commas.
    /// </summary>
    public string? Tags { get; set; }

    /// <summary>
    /// If provided, will only return tickets of this type.
    /// </summary>
    public string? TicketType { get; set; }

    /// <summary>
    /// If provided, will only return tickets where the URL matches or contains the substring
    /// </summary>
    public string? TicketUrl { get; set; }
}
