using System.Net.Http;
using System.Text.Json;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Filestorage;

public partial class AccountTokenClient
{
    private RawClient _client;

    internal AccountTokenClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns the account token for the end user with the provided public token.
    /// </summary>
    public async Task<AccountToken> RetrieveAsync(
        string publicToken,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"filestorage/v1/account-token/{publicToken}",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<AccountToken>(responseBody)!;
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
