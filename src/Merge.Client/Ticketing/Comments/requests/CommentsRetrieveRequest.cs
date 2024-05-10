using Merge.Client.Ticketing;

namespace Merge.Client.Ticketing;

public class CommentsRetrieveRequest
{
    /// <summary>
    /// Which relations should be returned in expanded form. Multiple relation names should be comma separated without spaces.
    /// </summary>
    public CommentsRetrieveRequestExpand? Expand { get; init; }

    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; init; }
}
