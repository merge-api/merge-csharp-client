using Merge.Client;

#nullable enable

namespace Merge.Client.Accounting;

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
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "accounting/v1/delete-account"
            }
        );
    }
}
