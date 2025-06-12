using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Crm;

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
    /// <example><code>
    /// await client.Crm.AccountToken.RetrieveAsync("public_token");
    /// </code></example>
    public async Task<AccountToken> RetrieveAsync(
        string publicToken,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "crm/v1/account-token/{0}",
                        ValueConvert.ToPathParameterString(publicToken)
                    ),
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<AccountToken>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MergeException("Failed to deserialize response", e);
            }
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
