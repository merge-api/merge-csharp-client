using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

public partial class LinkTokenClient
{
    private RawClient _client;

    internal LinkTokenClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Creates a link token to be used when linking a new end user.
    /// </summary>
    /// <example><code>
    /// await client.Accounting.LinkToken.CreateAsync(
    ///     new EndUserDetailsRequest
    ///     {
    ///         EndUserEmailAddress = "example@gmail.com",
    ///         EndUserOrganizationName = "Test Organization",
    ///         EndUserOriginId = "12345",
    ///         Categories = new List&lt;CategoriesEnum&gt;() { CategoriesEnum.Hris, CategoriesEnum.Ats },
    ///     }
    /// );
    /// </code></example>
    public async Task<LinkToken> CreateAsync(
        EndUserDetailsRequest request,
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
                    Path = "accounting/v1/link-token",
                    Body = request,
                    ContentType = "application/json",
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
                return JsonUtils.Deserialize<LinkToken>(responseBody)!;
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
