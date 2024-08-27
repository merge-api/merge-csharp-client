using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ticketing;

public record ProjectsUsersListRequest
{
    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    public string? Cursor { get; set; }

    /// <summary>
    /// Which relations should be returned in expanded form. Multiple relation names should be comma separated without spaces.
    /// </summary>
    public ProjectsUsersListRequestExpand? Expand { get; set; }

    /// <summary>
    /// Whether to include data that was marked as deleted by third party webhooks.
    /// </summary>
    public bool? IncludeDeletedData { get; set; }

    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; set; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    public int? PageSize { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
