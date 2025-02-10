using Merge.Client.Core;

namespace Merge.Client.Ats;

public record SyncStatusListRequest
{
    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    public string? Cursor { get; set; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    public int? PageSize { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
