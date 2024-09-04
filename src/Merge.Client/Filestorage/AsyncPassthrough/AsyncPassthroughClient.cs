using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Filestorage;

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
    /// <example>
    /// <code>
    /// await client.Filestorage.AsyncPassthrough.CreateAsync(
    ///     new Merge.Client.Filestorage.DataPassthroughRequest
    ///     {
    ///         Method = Merge.Client.Filestorage.MethodEnum.Get,
    ///         Path = "/scooters",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<AsyncPassthroughReciept> CreateAsync(
        DataPassthroughRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "filestorage/v1/async-passthrough",
                Body = request,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<AsyncPassthroughReciept>(responseBody)!;
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

    /// <summary>
    /// Retrieves data from earlier async-passthrough POST request
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Filestorage.AsyncPassthrough.RetrieveAsync("async_passthrough_receipt_id");
    /// </code>
    /// </example>
    public async Task<RemoteResponse> RetrieveAsync(
        string asyncPassthroughReceiptId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"filestorage/v1/async-passthrough/{asyncPassthroughReceiptId}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<RemoteResponse>(responseBody)!;
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
