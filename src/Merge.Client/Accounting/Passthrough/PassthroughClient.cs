using System.Text.Json;
using Merge.Client;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

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
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "accounting/v1/passthrough",
                Body = request
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
