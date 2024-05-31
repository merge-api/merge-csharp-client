using System.Text.Json;
using Merge.Client;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

public class AsyncPassthroughClient
{
    private RawClient _client;

    public AsyncPassthroughClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Asynchronously pull data from an endpoint not currently supported by Merge.
    /// </summary>
    public async Task<AsyncPassthroughReciept> CreateAsync(DataPassthroughRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/accounting/v1/async-passthrough",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<AsyncPassthroughReciept>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Retrieves data from earlier async-passthrough POST request
    /// </summary>
    public async Task<RemoteResponse> RetrieveAsync(string asyncPassthroughReceiptId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/accounting/v1/async-passthrough/{asyncPassthroughReceiptId}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<RemoteResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
