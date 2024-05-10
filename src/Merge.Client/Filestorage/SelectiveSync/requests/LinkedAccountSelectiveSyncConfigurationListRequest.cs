using Merge.Client.Filestorage;

namespace Merge.Client.Filestorage;

public class LinkedAccountSelectiveSyncConfigurationListRequest
{
    /// <summary>
    /// The selective syncs associated with a linked account.
    /// </summary>
    public List<LinkedAccountSelectiveSyncConfigurationRequest> SyncConfigurations { get; init; }
}
