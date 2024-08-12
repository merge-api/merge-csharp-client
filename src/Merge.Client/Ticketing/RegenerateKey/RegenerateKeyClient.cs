using System.Net.Http;
using System.Text.Json;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ticketing;

public partial class RegenerateKeyClient
{
    private RawClient _client;

    internal RegenerateKeyClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Exchange remote keys.
    /// </summary>
    public async Task<RemoteKey> CreateAsync(
        RemoteKeyForRegenerationRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "ticketing/v1/regenerate-key",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<RemoteKey>(responseBody)!;
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
