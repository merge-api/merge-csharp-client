using System.Net.Http;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

public class DeleteAccountClient
{
    private RawClient _client;

    public DeleteAccountClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Delete a linked account.
    /// </summary>
    public async Task DeleteAsync(RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "crm/v1/delete-account",
                Options = options
            }
        );
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        throw new MergeApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }
}
