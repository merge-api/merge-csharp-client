using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

public class TimeOffListRequest
{
    /// <summary>
    /// If provided, will only return time off for this approver.
    /// </summary>
    public string? ApproverId { get; init; }

    /// <summary>
    /// If provided, will only return objects created after this datetime.
    /// </summary>
    public DateTime? CreatedAfter { get; init; }

    /// <summary>
    /// If provided, will only return objects created before this datetime.
    /// </summary>
    public DateTime? CreatedBefore { get; init; }

    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// If provided, will only return time off for this employee.
    /// </summary>
    public string? EmployeeId { get; init; }

    /// <summary>
    /// If provided, will only return employees that ended after this datetime.
    /// </summary>
    public DateTime? EndedAfter { get; init; }

    /// <summary>
    /// If provided, will only return time-offs that ended before this datetime.
    /// </summary>
    public DateTime? EndedBefore { get; init; }

    /// <summary>
    /// Which relations should be returned in expanded form. Multiple relation names should be comma separated without spaces.
    /// </summary>
    public TimeOffListRequestExpand? Expand { get; init; }

    /// <summary>
    /// Whether to include data that was marked as deleted by third party webhooks.
    /// </summary>
    public bool? IncludeDeletedData { get; init; }

    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; init; }

    /// <summary>
    /// If provided, only objects synced by Merge after this date time will be returned.
    /// </summary>
    public DateTime? ModifiedAfter { get; init; }

    /// <summary>
    /// If provided, only objects synced by Merge before this date time will be returned.
    /// </summary>
    public DateTime? ModifiedBefore { get; init; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// Deprecated. Use show_enum_origins.
    /// </summary>
    public TimeOffListRequestRemoteFields? RemoteFields { get; init; }

    /// <summary>
    /// The API provider's ID for the given object.
    /// </summary>
    public string? RemoteId { get; init; }

    /// <summary>
    /// If provided, will only return TimeOff with this request type. Options: ('VACATION', 'SICK', 'PERSONAL', 'JURY_DUTY', 'VOLUNTEER', 'BEREAVEMENT')
    ///
    /// - `VACATION` - VACATION
    /// - `SICK` - SICK
    /// - `PERSONAL` - PERSONAL
    /// - `JURY_DUTY` - JURY_DUTY
    /// - `VOLUNTEER` - VOLUNTEER
    /// - `BEREAVEMENT` - BEREAVEMENT
    /// </summary>
    public TimeOffListRequestRequestType? RequestType { get; init; }

    /// <summary>
    /// A comma separated list of enum field names for which you'd like the original values to be returned, instead of Merge's normalized enum values. [Learn more](https://help.merge.dev/en/articles/8950958-show_enum_origins-query-parameter)
    /// </summary>
    public TimeOffListRequestShowEnumOrigins? ShowEnumOrigins { get; init; }

    /// <summary>
    /// If provided, will only return time-offs that started after this datetime.
    /// </summary>
    public DateTime? StartedAfter { get; init; }

    /// <summary>
    /// If provided, will only return time-offs that started before this datetime.
    /// </summary>
    public DateTime? StartedBefore { get; init; }

    /// <summary>
    /// If provided, will only return TimeOff with this status. Options: ('REQUESTED', 'APPROVED', 'DECLINED', 'CANCELLED', 'DELETED')
    ///
    /// - `REQUESTED` - REQUESTED
    /// - `APPROVED` - APPROVED
    /// - `DECLINED` - DECLINED
    /// - `CANCELLED` - CANCELLED
    /// - `DELETED` - DELETED
    /// </summary>
    public TimeOffListRequestStatus? Status { get; init; }
}
