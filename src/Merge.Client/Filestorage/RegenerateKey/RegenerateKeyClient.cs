using System.Text.Json;
using Merge.Client;
using Merge.Client.Filestorage;

namespace Merge.Client.Filestorage;

public class RegenerateKeyClient
{
    private RawClient _client;

    public RegenerateKeyClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Exchange remote keys.
    /// </summary>
    public async Task<RemoteKey> CreateAsync(RemoteKeyForRegenerationRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/filestorage/v1/regenerate-key",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<RemoteKey>(responseBody);
        }
        throw new Exception();
    }
}
