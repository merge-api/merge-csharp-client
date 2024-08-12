using System.Net.Http;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

public partial class DeleteAccountClient
{
    private RawClient _client;

    internal DeleteAccountClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Delete a linked account.
    /// </summary>
    public async System.Threading.Tasks.Task DeleteAsync(RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "accounting/v1/delete-account",
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
            responseBody
        );
    }
}
