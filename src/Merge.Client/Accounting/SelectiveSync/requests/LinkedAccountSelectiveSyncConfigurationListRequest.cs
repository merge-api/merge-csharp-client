using Merge.Client.Accounting;

namespace Merge.Client.Accounting;

public class LinkedAccountSelectiveSyncConfigurationListRequest
{
    /// <summary>
    /// The selective syncs associated with a linked account.
    /// </summary>
    public List<LinkedAccountSelectiveSyncConfigurationRequest> SyncConfigurations { get; init; }
}
