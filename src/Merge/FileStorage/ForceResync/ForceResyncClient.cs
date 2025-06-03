using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge;
using Merge.Core;

namespace Merge.FileStorage.ForceResync;

public partial class ForceResyncClient
{
    private RawClient _client;

    internal ForceResyncClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Force re-sync of all models. This endpoint is available for monthly, quarterly, and highest sync frequency customers on the Professional or Enterprise plans. Doing so will consume a sync credit for the relevant linked account. Force re-syncs can also be triggered manually in the Merge Dashboard and is available for all customers.
    /// </summary>
    /// <example><code>
    /// await client.FileStorage.ForceResync.SyncStatusResyncCreateAsync();
    /// </code></example>
    public async Task<IEnumerable<SyncStatus>> SyncStatusResyncCreateAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return await _client
            .Options.ExceptionHandler.TryCatchAsync(async () =>
            {
                var response = await _client
                    .SendRequestAsync(
                        new JsonRequest
                        {
                            BaseUrl = _client.Options.Environment.Api,
                            Method = HttpMethod.Post,
                            Path = "filestorage/v1/sync-status/resync",
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
                        return JsonUtils.Deserialize<IEnumerable<SyncStatus>>(responseBody)!;
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
            })
            .ConfigureAwait(false);
    }
}
