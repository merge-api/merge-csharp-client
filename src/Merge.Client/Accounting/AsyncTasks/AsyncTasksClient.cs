using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

public partial class AsyncTasksClient
{
    private RawClient _client;

    internal AsyncTasksClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns an `AsyncPostTask` object with the given `id`.
    /// </summary>
    /// <example><code>
    /// await client.Accounting.AsyncTasks.RetrieveAsync("id");
    /// </code></example>
    public async Task<AsyncPostTask> RetrieveAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "accounting/v1/async-tasks/{0}",
                        ValueConvert.ToPathParameterString(id)
                    ),
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
                return JsonUtils.Deserialize<AsyncPostTask>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new BaseMergeClientException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new BaseMergeClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }
}
