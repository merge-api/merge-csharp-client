using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

public partial class AccountTokenClient
{
    private RawClient _client;

    internal AccountTokenClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns the account token for the end user with the provided public token.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Ticketing.AccountToken.RetrieveAsync("public_token");
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<AccountToken> RetrieveAsync(
        string publicToken,
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
                    Path = $"ticketing/v1/account-token/{publicToken}",
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
                return JsonUtils.Deserialize<AccountToken>(responseBody)!;
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
