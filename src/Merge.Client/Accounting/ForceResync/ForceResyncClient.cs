using System.Text.Json;
using Merge.Client;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

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
    public async Task<IEnumerable<SyncStatus>> SyncStatusResyncCreateAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "accounting/v1/sync-status/resync"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<SyncStatus>>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
