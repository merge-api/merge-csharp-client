using System.Net.Http;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Crm;

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
    /// <example>
    /// <code>
    /// await client.Crm.DeleteAccount.DeleteAsync();
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task DeleteAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "crm/v1/delete-account",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
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
