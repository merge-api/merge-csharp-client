using System.Text.Json;
using Merge.Client;
using Merge.Client.Ticketing;

namespace Merge.Client.Ticketing;

public class PassthroughClient
{
    private RawClient _client;

    public PassthroughClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Pull data from an endpoint not currently supported by Merge.
    /// </summary>
    public async Task<RemoteResponse> CreateAsync(DataPassthroughRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/ticketing/v1/passthrough",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<RemoteResponse>(responseBody);
        }
        throw new Exception();
    }
}
