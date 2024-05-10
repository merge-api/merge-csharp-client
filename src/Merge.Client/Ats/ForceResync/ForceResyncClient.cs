using System.Text.Json;
using Merge.Client;
using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class ForceResyncClient
{
    private RawClient _client;

    public ForceResyncClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Force re-sync of all models. This is available for all organizations via the dashboard. Force re-sync is also available programmatically via API for monthly, quarterly, and highest sync frequency customers on the Launch, Professional, or Enterprise plans. Doing so will consume a sync credit for the relevant linked account.
    /// </summary>
    public async Task<List<SyncStatus>> SyncStatusResyncCreateAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/ats/v1/sync-status/resync"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<List<SyncStatus>>(responseBody);
        }
        throw new Exception();
    }
}
