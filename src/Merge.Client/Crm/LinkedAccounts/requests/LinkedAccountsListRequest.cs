using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class LinkedAccountsListRequest
{
    /// <summary>
    /// Options: `accounting`, `ats`, `crm`, `filestorage`, `hris`, `mktg`, `ticketing`
    ///
    /// - `hris` - hris
    /// - `ats` - ats
    /// - `accounting` - accounting
    /// - `ticketing` - ticketing
    /// - `crm` - crm
    /// - `mktg` - mktg
    /// - `filestorage` - filestorage
    /// </summary>
    public LinkedAccountsListRequestCategory? Category { get; init; }

    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// If provided, will only return linked accounts associated with the given email address.
    /// </summary>
    public string? EndUserEmailAddress { get; init; }

    /// <summary>
    /// If provided, will only return linked accounts associated with the given organization name.
    /// </summary>
    public string? EndUserOrganizationName { get; init; }

    /// <summary>
    /// If provided, will only return linked accounts associated with the given origin ID.
    /// </summary>
    public string? EndUserOriginId { get; init; }

    /// <summary>
    /// Comma-separated list of EndUser origin IDs, making it possible to specify multiple EndUsers at once.
    /// </summary>
    public string? EndUserOriginIds { get; init; }

    public string? Id { get; init; }

    /// <summary>
    /// Comma-separated list of LinkedAccount IDs, making it possible to specify multiple LinkedAccounts at once.
    /// </summary>
    public string? Ids { get; init; }

    /// <summary>
    /// If `true`, will include complete production duplicates of the account specified by the `id` query parameter in the response. `id` must be for a complete production linked account.
    /// </summary>
    public bool? IncludeDuplicates { get; init; }

    /// <summary>
    /// If provided, will only return linked accounts associated with the given integration name.
    /// </summary>
    public string? IntegrationName { get; init; }

    /// <summary>
    /// If included, will only include test linked accounts. If not included, will only include non-test linked accounts.
    /// </summary>
    public string? IsTestAccount { get; init; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// Filter by status. Options: `COMPLETE`, `INCOMPLETE`, `RELINK_NEEDED`
    /// </summary>
    public string? Status { get; init; }
}
