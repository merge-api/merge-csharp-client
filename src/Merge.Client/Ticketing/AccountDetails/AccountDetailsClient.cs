using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

public partial class AccountDetailsClient
{
    private RawClient _client;

    internal AccountDetailsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get details for a linked account.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Ticketing.AccountDetails.RetrieveAsync();
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<AccountDetails> RetrieveAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "ticketing/v1/account-details",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<AccountDetails>(responseBody)!;
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
