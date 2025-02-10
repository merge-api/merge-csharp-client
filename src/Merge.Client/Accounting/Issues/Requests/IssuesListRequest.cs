using Merge.Client.Core;

namespace Merge.Client.Accounting;

public record IssuesListRequest
{
    public string? AccountToken { get; set; }

    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    public string? Cursor { get; set; }

    /// <summary>
    /// If included, will only include issues whose most recent action occurred before this time
    /// </summary>
    public string? EndDate { get; set; }

    public string? EndUserOrganizationName { get; set; }

    /// <summary>
    /// If provided, will only return issues whose first incident time was after this datetime.
    /// </summary>
    public DateTime? FirstIncidentTimeAfter { get; set; }

    /// <summary>
    /// If provided, will only return issues whose first incident time was before this datetime.
    /// </summary>
    public DateTime? FirstIncidentTimeBefore { get; set; }

    /// <summary>
    /// If true, will include muted issues
    /// </summary>
    public string? IncludeMuted { get; set; }

    public string? IntegrationName { get; set; }

    /// <summary>
    /// If provided, will only return issues whose last incident time was after this datetime.
    /// </summary>
    public DateTime? LastIncidentTimeAfter { get; set; }

    /// <summary>
    /// If provided, will only return issues whose last incident time was before this datetime.
    /// </summary>
    public DateTime? LastIncidentTimeBefore { get; set; }

    /// <summary>
    /// If provided, will only include issues pertaining to the linked account passed in.
    /// </summary>
    public string? LinkedAccountId { get; set; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// If included, will only include issues whose most recent action occurred after this time
    /// </summary>
    public string? StartDate { get; set; }

    /// <summary>
    /// Status of the issue. Options: ('ONGOING', 'RESOLVED')
    ///
    /// - `ONGOING` - ONGOING
    /// - `RESOLVED` - RESOLVED
    /// </summary>
    public IssuesListRequestStatus? Status { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
