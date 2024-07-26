using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

public class BankInfoListRequest
{
    /// <summary>
    /// If provided, will only return BankInfo's with this account type. Options: ('SAVINGS', 'CHECKING')
    ///
    /// - `SAVINGS` - SAVINGS
    /// - `CHECKING` - CHECKING
    /// </summary>
    public BankInfoListRequestAccountType? AccountType { get; init; }

    /// <summary>
    /// If provided, will only return BankInfo's with this bank name.
    /// </summary>
    public string? BankName { get; init; }

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
    /// If provided, will only return bank accounts for this employee.
    /// </summary>
    public string? EmployeeId { get; init; }

    /// <summary>
    /// Which relations should be returned in expanded form. Multiple relation names should be comma separated without spaces.
    /// </summary>
    public string? Expand { get; init; }

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
    /// Overrides the default ordering for this endpoint. Possible values include: remote_created_at, -remote_created_at.
    /// </summary>
    public BankInfoListRequestOrderBy? OrderBy { get; init; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// Deprecated. Use show_enum_origins.
    /// </summary>
    public string? RemoteFields { get; init; }

    /// <summary>
    /// The API provider's ID for the given object.
    /// </summary>
    public string? RemoteId { get; init; }

    /// <summary>
    /// A comma separated list of enum field names for which you'd like the original values to be returned, instead of Merge's normalized enum values. [Learn more](https://help.merge.dev/en/articles/8950958-show_enum_origins-query-parameter)
    /// </summary>
    public string? ShowEnumOrigins { get; init; }
}
