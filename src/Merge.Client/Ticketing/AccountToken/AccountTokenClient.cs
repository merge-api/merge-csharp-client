using System.Text.Json;
using Merge.Client;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

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
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"ticketing/v1/account-token/{publicToken}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<AccountToken>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
