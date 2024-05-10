using Merge.Client.Hris;

namespace Merge.Client.Hris;

public class TimeOffRetrieveRequest
{
    /// <summary>
    /// Which relations should be returned in expanded form. Multiple relation names should be comma separated without spaces.
    /// </summary>
    public TimeOffRetrieveRequestExpand? Expand { get; init; }

    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; init; }

    /// <summary>
    /// Deprecated. Use show_enum_origins.
    /// </summary>
    public TimeOffRetrieveRequestRemoteFields? RemoteFields { get; init; }

    /// <summary>
    /// A comma separated list of enum field names for which you'd like the original values to be returned, instead of Merge's normalized enum values. [Learn more](https://help.merge.dev/en/articles/8950958-show_enum_origins-query-parameter)
    /// </summary>
    public TimeOffRetrieveRequestShowEnumOrigins? ShowEnumOrigins { get; init; }
}
