using Merge.Client;

namespace Merge.Client.Ticketing;

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
    public async void DeleteAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/ticketing/v1/delete-account"
            }
        );
    }
}
