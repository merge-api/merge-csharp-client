using Merge.Client;

#nullable enable

namespace Merge.Client.Filestorage;

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
                Path = "filestorage/v1/delete-account"
            }
        );
    }
}
