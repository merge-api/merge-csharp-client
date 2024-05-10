using Merge.Client.Hris;

namespace Merge.Client.Hris;

public class LinkedAccountSelectiveSyncConfigurationListRequest
{
    /// <summary>
    /// The selective syncs associated with a linked account.
    /// </summary>
    public List<LinkedAccountSelectiveSyncConfigurationRequest> SyncConfigurations { get; init; }
}
