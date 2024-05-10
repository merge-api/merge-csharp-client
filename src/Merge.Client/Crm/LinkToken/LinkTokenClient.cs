using System.Text.Json;
using Merge.Client;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class LinkTokenClient
{
    private RawClient _client;

    public LinkTokenClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Creates a link token to be used when linking a new end user.
    /// </summary>
    public async Task<LinkToken> CreateAsync(EndUserDetailsRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Post, Path = "/crm/v1/link-token" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<LinkToken>(responseBody);
        }
        throw new Exception();
    }
}
