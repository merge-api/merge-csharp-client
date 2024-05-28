namespace Merge.Client.Ticketing;

public class SyncStatusListRequest
{
    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    public int? PageSize { get; init; }
}
