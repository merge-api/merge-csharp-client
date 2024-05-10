using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class LinkedAccountSelectiveSyncConfigurationListRequest
{
    /// <summary>
    /// The selective syncs associated with a linked account.
    /// </summary>
    public List<LinkedAccountSelectiveSyncConfigurationRequest> SyncConfigurations { get; init; }
}
