using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class IssuesListRequest
{
    public string? AccountToken { get; init; }

    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// If included, will only include issues whose most recent action occurred before this time
    /// </summary>
    public string? EndDate { get; init; }

    public string? EndUserOrganizationName { get; init; }

    /// <summary>
    /// If provided, will only return issues whose first incident time was after this datetime.
    /// </summary>
    public DateTime? FirstIncidentTimeAfter { get; init; }

    /// <summary>
    /// If provided, will only return issues whose first incident time was before this datetime.
    /// </summary>
    public DateTime? FirstIncidentTimeBefore { get; init; }

    /// <summary>
    /// If true, will include muted issues
    /// </summary>
    public string? IncludeMuted { get; init; }

    public string? IntegrationName { get; init; }

    /// <summary>
    /// If provided, will only return issues whose last incident time was after this datetime.
    /// </summary>
    public DateTime? LastIncidentTimeAfter { get; init; }

    /// <summary>
    /// If provided, will only return issues whose last incident time was before this datetime.
    /// </summary>
    public DateTime? LastIncidentTimeBefore { get; init; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// If included, will only include issues whose most recent action occurred after this time
    /// </summary>
    public string? StartDate { get; init; }

    /// <summary>
    /// Status of the issue. Options: ('ONGOING', 'RESOLVED')
    ///
    /// - `ONGOING` - ONGOING
    /// - `RESOLVED` - RESOLVED
    /// </summary>
    public IssuesListRequestStatus? Status { get; init; }
}
