using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class TasksRetrieveRequest
{
    /// <summary>
    /// Which relations should be returned in expanded form. Multiple relation names should be comma separated without spaces.
    /// </summary>
    public TasksRetrieveRequestExpand? Expand { get; init; }

    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; init; }

    /// <summary>
    /// Whether to include all remote fields, including fields that Merge did not map to common models, in a normalized format.
    /// </summary>
    public bool? IncludeRemoteFields { get; init; }
}
