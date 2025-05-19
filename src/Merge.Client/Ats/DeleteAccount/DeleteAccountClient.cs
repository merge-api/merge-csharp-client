using System.Net.Http;
using System.Threading;
using global::System.Threading.Tasks;
using Merge.Client.Core;

namespace Merge.Client.Ats;

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
    /// <example><code>
    /// await client.Ats.DeleteAccount.DeleteAsync();
    /// </code></example>
    public async global::System.Threading.Tasks.Task DeleteAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "ats/v1/delete-account",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new MergeApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }
}
