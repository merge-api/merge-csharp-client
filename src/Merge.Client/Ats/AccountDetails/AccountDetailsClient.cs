using System.Text.Json;
using Merge.Client;
using Merge.Client.Ats;

#nullable enable

namespace Merge.Client.Ats;

public class AccountDetailsClient
{
    private RawClient _client;

    public AccountDetailsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get details for a linked account.
    /// </summary>
    public async Task<AccountDetails> RetrieveAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "ats/v1/account-details"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<AccountDetails>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
