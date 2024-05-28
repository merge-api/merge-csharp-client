using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

public class UsersRetrieveRequest
{
    /// <summary>
    /// Which relations should be returned in expanded form. Multiple relation names should be comma separated without spaces.
    /// </summary>
    public UsersRetrieveRequestExpand? Expand { get; init; }

    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; init; }
}
