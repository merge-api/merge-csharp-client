using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

#nullable enable

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
    /// <example>
    /// <code>
    /// await client.Accounting.AsyncTasks.RetrieveAsync("id");
    /// </code>
    /// </example>
    public async Task<AsyncPostTask> RetrieveAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"accounting/v1/async-tasks/{id}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<AsyncPostTask>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MergeException("Failed to deserialize response", e);
            }
        }

        throw new MergeApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }
}
