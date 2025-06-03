using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

public partial class SyncStatusClient
{
    private RawClient _client;

    internal SyncStatusClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get sync status for the current sync and the most recently finished sync. `last_sync_start` represents the most recent time any sync began. `last_sync_finished` represents the most recent time any sync completed. These timestamps may correspond to different sync instances which may result in a sync start time being later than a separate sync completed time. To ensure you are retrieving the latest available data reference the `last_sync_finished` timestamp where `last_sync_result` is `DONE`. Possible values for `status` and `last_sync_result` are `DISABLED`, `DONE`, `FAILED`, `PARTIALLY_SYNCED`, `PAUSED`, `SYNCING`. Learn more about sync status in our [Help Center](https://help.merge.dev/en/articles/8184193-merge-sync-statuses).
    /// </summary>
    private async Task<PaginatedSyncStatusList> ListInternalAsync(
        SyncStatusListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Cursor != null)
        {
            _query["cursor"] = request.Cursor;
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize.Value.ToString();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.Api,
                    Method = HttpMethod.Get,
                    Path = "accounting/v1/sync-status",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<PaginatedSyncStatusList>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MergeException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new MergeApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Get sync status for the current sync and the most recently finished sync. `last_sync_start` represents the most recent time any sync began. `last_sync_finished` represents the most recent time any sync completed. These timestamps may correspond to different sync instances which may result in a sync start time being later than a separate sync completed time. To ensure you are retrieving the latest available data reference the `last_sync_finished` timestamp where `last_sync_result` is `DONE`. Possible values for `status` and `last_sync_result` are `DISABLED`, `DONE`, `FAILED`, `PARTIALLY_SYNCED`, `PAUSED`, `SYNCING`. Learn more about sync status in our [Help Center](https://help.merge.dev/en/articles/8184193-merge-sync-statuses).
    /// </summary>
    /// <example><code>
    /// await client.Accounting.SyncStatus.ListAsync(new SyncStatusListRequest());
    /// </code></example>
    public async Task<Pager<SyncStatus>> ListAsync(
        SyncStatusListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        if (request is not null)
        {
            request = request with { };
        }
        var pager = await CursorPager<
            SyncStatusListRequest,
            RequestOptions?,
            PaginatedSyncStatusList,
            string?,
            SyncStatus
        >
            .CreateInstanceAsync(
                request,
                options,
                ListInternalAsync,
                (request, cursor) =>
                {
                    request.Cursor = cursor;
                },
                response => response?.Next,
                response => response?.Results?.ToList(),
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }
}
