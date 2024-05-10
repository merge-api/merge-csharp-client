using System.Text.Json;
using Merge.Client;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class SelectiveSyncClient
{
    private RawClient _client;

    public SelectiveSyncClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get a linked account's selective syncs.
    /// </summary>
    public async Task<List<LinkedAccountSelectiveSyncConfiguration>> ConfigurationsListAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/crm/v1/selective-sync/configurations"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<List<LinkedAccountSelectiveSyncConfiguration>>(
                responseBody
            );
        }
        throw new Exception();
    }

    /// <summary>
    /// Replace a linked account's selective syncs.
    /// </summary>
    public async Task<List<LinkedAccountSelectiveSyncConfiguration>> ConfigurationsUpdateAsync(
        LinkedAccountSelectiveSyncConfigurationListRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Put,
                Path = "/crm/v1/selective-sync/configurations"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<List<LinkedAccountSelectiveSyncConfiguration>>(
                responseBody
            );
        }
        throw new Exception();
    }

    /// <summary>
    /// Get metadata for the conditions available to a linked account.
    /// </summary>
    public async Task<PaginatedConditionSchemaList> MetaListAsync(
        SelectiveSyncMetaListRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.CommonModel != null)
        {
            _query["common_model"] = request.CommonModel;
        }
        if (request.Cursor != null)
        {
            _query["cursor"] = request.Cursor;
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/crm/v1/selective-sync/meta",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedConditionSchemaList>(responseBody);
        }
        throw new Exception();
    }
}
