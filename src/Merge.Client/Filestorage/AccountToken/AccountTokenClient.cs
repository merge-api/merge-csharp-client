using System.Text.Json;
using Merge.Client;
using Merge.Client.Filestorage;

#nullable enable

namespace Merge.Client.Filestorage;

public class AccountTokenClient
{
    private RawClient _client;

    public AccountTokenClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns the account token for the end user with the provided public token.
    /// </summary>
    public async Task<AccountToken> RetrieveAsync(string publicToken)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/filestorage/v1/account-token/{publicToken}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<AccountToken>(responseBody);
        }
        throw new Exception();
    }
}
