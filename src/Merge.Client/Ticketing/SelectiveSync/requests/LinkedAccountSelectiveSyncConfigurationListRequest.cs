using Merge.Client.Ticketing;

namespace Merge.Client.Ticketing;

public class LinkedAccountSelectiveSyncConfigurationListRequest
{
    /// <summary>
    /// The selective syncs associated with a linked account.
    /// </summary>
    public List<LinkedAccountSelectiveSyncConfigurationRequest> SyncConfigurations { get; init; }
}
