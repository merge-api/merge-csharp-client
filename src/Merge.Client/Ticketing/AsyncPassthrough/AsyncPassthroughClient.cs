using System.Text.Json;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Ticketing;

public partial class AsyncPassthroughClient
{
    private RawClient _client;

    internal AsyncPassthroughClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Asynchronously pull data from an endpoint not currently supported by Merge.
    /// </summary>
    /// <example><code>
    /// await client.Ticketing.AsyncPassthrough.CreateAsync(
    ///     new Merge.Client.Ticketing.DataPassthroughRequest
    ///     {
    ///         Method = Merge.Client.Ticketing.MethodEnum.Get,
    ///         Path = "/scooters",
    ///     }
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task<AsyncPassthroughReciept> CreateAsync(
        DataPassthroughRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "ticketing/v1/async-passthrough",
                    Body = request,
                    ContentType = "application/json",
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
                return JsonUtils.Deserialize<AsyncPassthroughReciept>(responseBody)!;
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
    /// Retrieves data from earlier async-passthrough POST request
    /// </summary>
    /// <example><code>
    /// await client.Ticketing.AsyncPassthrough.RetrieveAsync(
    ///     "async_passthrough_receipt_id",
    ///     new Merge.Client.Ticketing.AsyncPassthroughRetrieveRequest()
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task<OneOf<RemoteResponse, string>> RetrieveAsync(
        string asyncPassthroughReceiptId,
        AsyncPassthroughRetrieveRequest request,
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
                        "ticketing/v1/async-passthrough/{0}",
                        ValueConvert.ToPathParameterString(asyncPassthroughReceiptId)
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
                return JsonUtils.Deserialize<OneOf<RemoteResponse, string>>(responseBody)!;
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
}
